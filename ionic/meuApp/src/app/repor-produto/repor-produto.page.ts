import { Component } from '@angular/core';
import { MenuController } from '@ionic/angular';
import { ProdutosService } from '../produtos.service';
import { ReporProdutoService } from '../reporProduto.service';
@Component({
  selector: 'app-repor-produto',
  templateUrl: './repor-produto.page.html',
  styleUrls: ['./repor-produto.page.scss'],
})
export class ReporProdutoPage {
  ProdutoNome: string = '';
  ProdutoCode: number = 0;
  quantidade: number = 1;
  total: number = 0;
  chaveDeAcesso: string = '';  // Inicializa como string vazia
  chaveDeAcessoExibicao: string = ''; 
  valorTotal: number = 0;
  manualEdit: boolean = false;
  formatototal: string = '0,00';
  formatoValorTotal: string = '0,00';
  fornecedor: string = '';
  ListaDeProdutos: string = '';  // Lista de produtos do pedido
  cart: any[] = [];  // Carrinho de compras (onde os produtos são armazenados)
  hoje: Date = new Date();
  ano: string = this.hoje.getFullYear().toString();
  mes: string = (this.hoje.getMonth() + 1).toString().padStart(2, '0');
  dia: string = this.hoje.getDate().toString().padStart(2, '0');
  dataHoje: string = `${this.ano}-${this.mes}-${this.dia}`;

  fornecedores: any[] = [];
  constructor(
    private menu: MenuController,
    private ReporProdutoService: ReporProdutoService,
    private produtosService: ProdutosService,
  ) {}
  ngOnInit() {
    // Buscar fornecedores ao carregar a página
    this.produtosService.getFornecedores().subscribe(
        (fornecedores: any[]) => {
            this.fornecedores = fornecedores;  // Popula a lista de fornecedores com os dados recebidos da API
        },
        (error) => {
            console.error('Erro ao carregar fornecedores:', error);
            alert('Erro ao carregar fornecedores.');
        }
    );
}

  openMenu() {
    this.menu.open('first');
  }
  carregarfonrcedor(){
    if (!this.ProdutoCode || !this.fornecedor) {
      return;
    }
    this.cart = [];
  this.limparCampos(true); 
  this.carregarProduto();
  }
  carregarProduto() {
    if (!this.ProdutoCode || !this.fornecedor) {
      // Limpa os campos se não houver código do produto ou fornecedor selecionado
      this.limparCampos(false);
      this.ProdutoNome = '---';
      this.quantidade = 1;
      return;
    }
  
    // Chama o serviço para buscar o produto com base no código e fornecedor
    this.produtosService.listarProdutosPorCodigoFornecedor(this.ProdutoCode, this.fornecedor).subscribe({
      next: (produtos) => {
        if (produtos && produtos.length > 0) {
          const produto = produtos[0];
          this.ProdutoNome = produto.Nome || '---';
          this.quantidade = 1;
  
         
  
         
        } else {
          // Se não encontrar o produto, limpa os campos
          this.limparCampos(false);
          this.ProdutoNome = '---';
          this.quantidade = 1;
        }
      },
      error: (err) => {
        console.error('Erro ao carregar produto:', err);
        // Limpa os campos em caso de erro
        this.limparCampos(false);
        this.ProdutoNome = '---';
        this.quantidade = 1;
      },
    });
  }
  
  

  // Método para adicionar ao carrinho
  addToCart() {
    if (!this.ProdutoNome || this.ProdutoNome === '---') {
      alert('Digite o código de um produto que corresponde ao fornecedor escolhido!');
      return;
    }
    if (!this.quantidade || this.quantidade <= 0) {
      alert('Quantidade inválida! \n\nAdicione apenas valores positivos maiores que 0');
      return;
    }
    
    this.total = this.converterNumero(this.formatototal);
  
    // Cria o objeto do produto com todas as informações
    const item = {
      code: this.ProdutoCode,
      name: this.ProdutoNome,
      quantidade: this.quantidade,
      total: this.total,
      fornecedor: this.fornecedor
    };
  
    this.cart.push(item);
  
    // Atualiza o valor total do carrinho
    this.valorTotal += this.total;
    this.formatoValorTotal = this.valorTotal.toLocaleString('pt-BR', { minimumFractionDigits: 2, maximumFractionDigits: 2 });
    this.limparCampos(true);  // Limpa os campos
  }
  

  limparCampos(full: boolean = true) {
    if (full) {
      // Limpa os campos do formulário e também a variável de controle do carrinho
      this.ProdutoCode = 0;
      this.ProdutoNome = '';
      this.quantidade = 1;
      this.total = 0;
      this.formatototal = '0,00';
      this.ListaDeProdutos = '';
    }
  }
 // Método para remover produto do carrinho
 removeFromCart(index: number) {
  const itemRemovido = this.cart[index];

  // Atualiza o valor total ao subtrair o total do item removido
  this.valorTotal -= itemRemovido.total;
  this.formatoValorTotal = this.valorTotal.toLocaleString('pt-BR', { minimumFractionDigits: 2, maximumFractionDigits: 2 });
  // Remove o item do carrinho
  this.cart.splice(index, 1);
}



  // Calcula o total do carrinho
  getTotal() {
    return this.cart.reduce((total, item) => total + item.total, 0);
  }
  


 // Confirma o pedido
 ConfirmarCadastro() {
  if (this.cart.length === 0) {
    alert('Carrinho vazio!');
    return;
  }
  this.atualizarEstoqueSubtracao();
  this.salvarReporProdutoEntrada();
  this.salvaReporProduto();

  alert('Reposição confirmado!');
  this.cart = [];
  this.limparCampos(true);    
  window.location.reload();
  
}

salvarReporProdutoEntrada() {
  let i = 0; // Array para armazenar os produtos

  while (i < this.cart.length) {
    const item = this.cart[i];
    this.ListaDeProdutos += `${item.code} | ${item.name} | ${item.quantidade} | ${this.formatoDinheiroDisplay(item.total)}\n`;
    // Dados para registrar o pedido de saída
    const novaReporProdutoEntrada = {
      Data: this.dataHoje,
      Produto: item.name,
      Fornecedor: item.fornecedor,
      Quantidade: item.quantidade,
      ValorDaCompra: item.total
    };

    // Chamada para salvar o pedido de saída
    this.ReporProdutoService.adicionarReporProdutoEntrada(novaReporProdutoEntrada).subscribe({
      error: (error) => {
        console.log('Erro ao registrar Reposição:', error);
        return;
      }
    });
    i++;
  }
 
}

atualizarEstoqueSubtracao() {
  let i = 0;
  while (i < this.cart.length) {
    const item = this.cart[i];

    this.produtosService.atualizarEstoqueSoma(item.code, item.quantidade).subscribe({
      next: (response) => {
        
      },
      error: (err) => {
        console.error(`Erro ao atualizar estoque do produto ${item.name}: `, err);
      }
    });
    i++;
  }
}


salvaReporProduto(){  
    const novaReporProduto = {
    Data: this.dataHoje,
    ListaDeProdutos: this.ListaDeProdutos,
    Fornecedor: this.fornecedor,
    ValorCompra: this.valorTotal,
    NotaFiscalDaCompra: this.chaveDeAcessoExibicao 
  };
  this.ReporProdutoService.adicionarReporProduto(novaReporProduto).subscribe({
    error: (error) => {
      console.log('Erro ao registrar Reposição:', error);
      return;
    }
    
  });
}


cancelSale() {
  this.cart = [];
  this.limparCampos(false);  // Não limpa todos os campos, pois não estamos fazendo a confirmação do pedido
  alert('Reposição cancelado!');
}


  formatoDinheiroDisplay(valor: number | undefined | null): string {
    if (valor == null) {
      return '0,00';
    }
    return valor.toLocaleString('pt-BR', {
      minimumFractionDigits: 2,
      maximumFractionDigits: 2,
    });
  }
  converterNumero(value: string): number {
    return parseFloat(value.replace(/\./g, '').replace(',', '.'));
}
formatoDinheiroValorTotal() {
  if (!this.manualEdit) { // Só aplica a lógica automática se não houver edição manual
    this.valorTotal = this.converterNumero(this.valorTotal.toString());
    this.formatoValorTotal = this.valorTotal.toLocaleString('pt-BR', { minimumFractionDigits: 2, maximumFractionDigits: 2 });  
  }
  this.manualEdit = false; // Reseta a flag após processar
}

formatarChaveDeAcesso() {
  // Remove tudo o que não for número
  let valor = this.chaveDeAcesso.replace(/\D/g, '');

  // Limita o valor a 44 caracteres (máximo de 44)
  if (valor.length > 48) {
    valor = valor.slice(0, 48);
  }

  // Formata a chave de acesso com espaços a cada 4 caracteres
  let chaveComEspacos = valor.replace(/(\d{4})(?=\d)/g, '$1 ');

  // Garantir que a chave de acesso não ultrapasse os 44 caracteres (com espaços)
  this.chaveDeAcessoExibicao = chaveComEspacos.slice(0, 48);

  // Atualiza a chave de acesso real (com espaços) para ser salva
  this.chaveDeAcesso = this.chaveDeAcessoExibicao;
}

formatoDinheiro() {
  this.total = this.converterNumero(this.formatototal);
  this.formatototal = this.total.toLocaleString('pt-BR', { minimumFractionDigits: 2, maximumFractionDigits: 2 });
}
}