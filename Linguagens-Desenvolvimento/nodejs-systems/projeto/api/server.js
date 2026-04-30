const express = require('express');
const mysql = require('mysql');
const cors = require('cors');
const bodyParser = require('body-parser');
const multer = require('multer');
const fs = require('fs');
const path = require('path');

const app = express();
const port = 3000;

// Middleware
app.use(cors());
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

// Configura o multer para armazenar as imagens temporariamente em memória
const storage = multer.memoryStorage();
const upload = multer({ storage: storage });

// Configuração do banco de dados MySQL
const db = mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: '',
    database: 'loja'
});

// Conectar ao MySQL
db.connect((err) => {
    if (err) {
        console.error('Erro ao conectar ao MySQL:', err);
        return;
    }
    console.log('Conectado ao MySQL.');
});

// Rota para adicionar produto
app.post('/produto', upload.single('Imagem'), (req, res) => {
    const { Nome, Quantidade, Fornecedor, QuantidadeMinima, PrecoUnitario } = req.body;

    let imageBuffer;
    if (req.file) {
        imageBuffer = req.file.buffer;
    } else {
        const defaultImagePath = path.join(__dirname, '../src/assets/padrao.jpg');
        imageBuffer = fs.readFileSync(defaultImagePath);
    }

    db.query(
        'INSERT INTO produto (Nome, Quantidade, Fornecedor, QuantidadeMinima, PrecoUnitario) VALUES (?, ?, ?, ?, ?)',
        [Nome, Quantidade, Fornecedor, QuantidadeMinima, PrecoUnitario],
        (err, result) => {
            if (err) {
                console.error('Erro ao adicionar produto:', err);
                return res.status(500).json({ message: 'Erro ao adicionar produto.', error: err.message });
            }

            const produtoId = result.insertId;

            db.query(
                'INSERT INTO fotodoproduto (CodigoDaFoto, image) VALUES (?, ?)',
                [produtoId, imageBuffer],
                (err) => {
                    if (err) {
                        console.error('Erro ao adicionar imagem:', err);
                        return res.status(500).json({ message: 'Erro ao adicionar imagem.', error: err.message });
                    }
                    res.json({ message: 'Produto e imagem adicionados com sucesso!', id: produtoId });
                }
            );
        }
    );
});

/// Rota para listar produtos com pesquisa
app.get('/produto', (req, res) => {
    const { nome, codigo, fornecedor } = req.query; // Captura os parâmetros de consulta
    let sql = 'SELECT * FROM produto';
    const params = [];

    // Verifica se há algum parâmetro para adicionar condições
    if (nome || codigo || fornecedor) {
        sql += ' WHERE';
    }

    if (nome) {
        sql += ' Nome LIKE ?';
        params.push(`%${nome}%`);
    }

    if (nome && (codigo || fornecedor)) {
        sql += ' AND'; // Adiciona o operador AND entre condições
    }

    if (codigo) {
        sql += ' Codigo = ?';
        params.push(codigo);
    }

    if ((nome || codigo) && fornecedor) {
        sql += ' AND'; // Adiciona o operador AND entre condições
    }

    if (fornecedor) {
        sql += ' Fornecedor LIKE ?';
        params.push(`%${fornecedor}%`);
    }
    sql += ';';
    
    db.query(sql, params, (err, results) => {
        if (err) {
            console.error('Erro ao listar produtos:', err);
            return res.status(500).json({ message: 'Erro ao listar produtos.', error: err.message });
        }
        res.json(results);
    });
});


// Excluir produto
app.delete('/produto/:id', (req, res) => {
    const { id } = req.params;
        db.query('DELETE FROM produto WHERE Codigo = ?', [id], (err, result) => {
            if (err) {
                console.error('Erro ao excluir produto:', err);
                return res.status(500).json({ message: 'Erro ao excluir produto.', error: err.message });
            }else{
                db.query('DELETE FROM fotodoproduto WHERE CodigoDaFoto = ?', [id], (err, result) => {
                    if (err) {
                        console.error('Erro ao excluir foto do produto:', err);
                        return res.status(500).json({ message: 'Erro ao excluir foto do produto.', error: err.message });
                    }});
            }

            if (result.affectedRows > 0) {
                res.json({ message: 'Produto excluído com sucesso!' });
            } else {
                res.status(404).json({ message: 'Produto não encontrado.' });
            }
        
    });
});

// Rota para listar fornecedores em cadastro de produto
app.get('/fornecedores', (req, res) => {
    db.query('SELECT Nome FROM fornecedor', (err, results) => {
        if (err) {
            console.error('Erro ao listar fornecedores:', err);
            return res.status(500).json({ message: 'Erro ao listar fornecedores.', error: err.message });
        }
        res.json(results);  // Retorna os nomes dos fornecedores
    });
});

// Rota para adicionar fornecedor
app.post('/fornecedor', (req, res) => {
        const { 
        Nome, 
        Insta, 
        Whats, 
        Site, 
        Endereco, 
        Numero, 
        Cidade, 
        CEP, 
        Obs,
        CPFCNPJ
    } = req.body;

    // Inserir dados na tabela fornecedor
    db.query(
        'INSERT INTO fornecedor (Nome, CPFCNPJ, Insta, Whats, Site, Endereco, Numero, Cidade, CEP, Obs) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)',
        [Nome,CPFCNPJ, Insta, Whats, Site, Endereco, Numero, Cidade, CEP, Obs],
        (err, result) => {
            if (err) {
                console.error('Erro ao adicionar fornecedor:', err);
                return res.status(500).json({ message: 'Erro ao adicionar fornecedor.', error: err.message });
            }

            const fornecedorId = result.insertId; // ID do fornecedor inserido

            res.json({ message: 'Fornecedor adicionado com sucesso!', id: fornecedorId });
        }
    );
});

// Rota para listar fornecedores com pesquisa
app.get('/fornecedor', (req, res) => {
    const { nome } = req.query;
    const { codigo } = req.query; // Captura os parâmetros de consulta
    let sql = 'SELECT * FROM fornecedor';
    const params = [];

    if (nome) {
        sql += ' WHERE Nome LIKE ?';
        params.push(`%${nome}%`);
    }
    if (codigo) {
        sql += ' WHERE Codigo LIKE ?';
        params.push(`%${codigo}%`);
    } 

    db.query(sql, params, (err, results) => {
        if (err) {
            console.error('Erro ao listar fornecedores:', err);
            return res.status(500).json({ message: 'Erro ao listar fornecedores.', error: err.message });
        }
        res.json(results);
    });
});

// Excluir fornecedor
app.delete('/fornecedor/:id', (req, res) => {
    const { id } = req.params;
        db.query('DELETE FROM fornecedor WHERE Codigo = ?', [id], (err, result) => {
            if (err) {
                console.error('Erro ao excluir fornecedor:', err);
                return res.status(500).json({ message: 'Erro ao excluir fornecedor.', error: err.message });
            }
            if (result.affectedRows > 0) {
                res.json({ message: 'Fornecedor excluído com sucesso!' });
            } else {
                res.status(404).json({ message: 'Fornecedor não encontrado.' });
            }
        
    });
});

// Iniciar o servidor
app.listen(port, () => {
    console.log(`API rodando na http://localhost:${port}`);
});

// Rota de login (autenticação)
app.post('/login', (req, res) => {
    const { usuario, senha } = req.body;
  
    // Consulta SQL para verificar o login com verificação sensível ao caso
    db.query(
      'SELECT * FROM usuario WHERE BINARY Nome = ? AND BINARY Senha = ?',
      [usuario, senha],
      (err, results) => {
        if (err) {
          console.error('Erro ao consultar banco de dados:', err);
          return res.status(500).json({ message: 'Erro ao autenticar.' });
        }
  
        if (results.length > 0) {
          res.json({ message: 'Login bem-sucedido' }); // Retorna sucesso se usuário e senha forem válidos
        } else {
          res.status(404).json({ message: 'Usuário ou senha inválidos' }); // Retorna erro caso não encontrem o usuário
        }
      }
    );
  });
  
// Rota para adicionar fornecedor
app.post('/registrarPedidoSaida', (req, res) => {
    const {
        Data,
        Produto,
        Fornecedor,
        Quantidade,
        ValorDaVenda
} = req.body;

db.query(
    'INSERT INTO saidadeproduto (Data, Produto, Fornecedor, Quantidade, ValorDaVenda) VALUES (?, ?, ?, ?, ?);',
    [Data, Produto, Fornecedor, Quantidade, ValorDaVenda],
    (err) => {
        if (err) {
            console.log('Erro ao adicionar Pedido:', err);
            return res.status(500).json({ message: 'Erro ao adicionar Pedido.', error: err.message });
        }
    }
);
});

app.post('/registrarPedido', (req, res) => {
    const {
        Data,
        ListaDeProdutos,
        Desconto,
        SubTotal,
        Total,
        FormaDePagamento
} = req.body;


db.query(
    'INSERT INTO registrarpedido (Data, ListaDeProdutos, Desconto, SubTotal, Total, FormaDePagamento) VALUES (?, ?, ?, ?, ?, ?)',
    [Data, ListaDeProdutos, Desconto, SubTotal, Total, FormaDePagamento],
    (err) => {
        if (err) {
            console.log('Erro ao registrar Pedido:', err);
            return res.status(500).json({ message: 'Erro ao registrar Pedido.', error: err.message });
        }
    }
);
});

// Rota para atualizar a quantidade do produto no estoque após a Registrar Pedido
app.put('/produto/:id/atualizarEstoqueSubtracao', (req, res) => {
    const { id } = req.params;  // Obtém o ID do produto
    const { quantidade } = req.body;  // A nova quantidade para o estoque
    db.query(
        'UPDATE produto SET Quantidade = Quantidade - ? WHERE Codigo = ?;',
        [quantidade, id],
        (err) => {
            if (err) {
                console.error('Erro ao atualizar estoque:', err);
                return res.status(500).json({ message: 'Erro ao atualizar estoque.', error: err.message });
            }
            res.json({ message: 'Estoque atualizado com sucesso!' });
        }
    );
});

// Rota para atualizar a quantidade do produto no estoque após a Reposição
app.put('/produto/:id/atualizarEstoqueSoma', (req, res) => {
    const { id } = req.params;  // Obtém o ID do produto
    const { quantidade } = req.body;  // A nova quantidade para o estoque
    db.query(
        'UPDATE produto SET Quantidade = Quantidade + ? WHERE Codigo = ?;',
        [quantidade, id],
        (err) => {
            if (err) {
                console.error('Erro ao atualizar estoque:', err);
                return res.status(500).json({ message: 'Erro ao atualizar estoque.', error: err.message });
            }
            res.json({ message: 'Estoque atualizado com sucesso!' });
        }
    );
});

app.post('/reporProdutoEntrada', (req, res) => {
    const {
        Data,
        Produto,
        Fornecedor,
        Quantidade,
        ValorDaCompra
} = req.body;


db.query(
    'INSERT INTO entradadeproduto (Data, Produto, Fornecedor, Quantidade, ValorDaCompra) VALUES (?, ?, ?, ?, ?);',
    [Data, Produto, Fornecedor, Quantidade, ValorDaCompra],
    (err) => {
        if (err) {
            console.log('Erro ao adicionar Reposição:', err);
            return res.status(500).json({ message: 'Erro ao adicionar Reposição.', error: err.message });
        }
    }
);
});

app.post('/reporProduto', (req, res) => {
    const {
        Data,
        ListaDeProdutos,
        Fornecedor,
        ValorCompra,
        NotaFiscalDaCompra
} = req.body;


db.query(
    'INSERT INTO reposicaoproduto (Data, ListaDeProdutos, Fornecedor, ValorCompra, NotaFiscalDaCompra) VALUES (?, ?, ?, ?, ?)',
    [Data, ListaDeProdutos, Fornecedor, ValorCompra, NotaFiscalDaCompra],
    (err) => {
        if (err) {
            console.log('Erro ao registrar Reposição:', err);
            return res.status(500).json({ message: 'Erro ao registrar Reposição.', error: err.message });
        }
    }
);
});



/*
PARA RODAR ENTRAR NA PASTA api E DIGITAR:

node server.js

LOGIN:
usuario: adm
senha: 123

*/