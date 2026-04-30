import { Component } from '@angular/core';
import { MenuController } from '@ionic/angular';
import { ProdutosService } from '../produtos.service';
import { RegistrarPedidoService } from '../registrarPedido.service';
@Component({
  selector: 'app-caixa',
  templateUrl: './caixa.page.html',
  styleUrls: ['./caixa.page.scss'],
})
export class CaixaPage {
  ProdutoNome: string = '';
  ProdutoCode: number = 0;
  quantidade: number = 0;
  unitPrice: number = 0;
  subtotal: number = 0;
  discount: number = 0;
  fornecedor: string = '';
  selectedItem: string = '';
  produtoEstoque: number = 0;
  ListaDeProdutos: string = '';  // Lista de produtos do pedido
  cart: any[] = [];  // Carrinho de compras (onde os produtos são armazenados)
  selectedPaymentMethods: string = '';
  paymentMethods = {
    credit: false,
    debit: false,
    cash: false,
    pix: false,
  };
  hoje: Date = new Date();
  ano: string = this.hoje.getFullYear().toString();
  mes: string = (this.hoje.getMonth() + 1).toString().padStart(2, '0');
  dia: string = this.hoje.getDate().toString().padStart(2, '0');
  dataHoje: string = `${this.ano}-${this.mes}-${this.dia}`;


  constructor(
    private menu: MenuController,
    private RegistrarPedidoService: RegistrarPedidoService,
    private produtosService: ProdutosService,
  ) {}

  openMenu() {
    this.menu.open('first');
  }

  carregarProduto() {
    if (!this.ProdutoCode) {
      this.limparCampos(false);
      this.ProdutoNome = '---';
          this.unitPrice = 0;
          this.produtoEstoque = 0;
          this.fornecedor =  '';
          this.quantidade = 0;
          this.calculateSubtotal();
      return;
    }
  
    this.produtosService.listarProdutosPorCodigo(this.ProdutoCode).subscribe({
      next: (produto) => {
        if (produto && produto.length > 0) {
          this.ProdutoNome = produto[0].Nome || '---';
          this.unitPrice = produto[0].PrecoUnitario || 0;
          this.produtoEstoque = produto[0].Quantidade || 0;
          this.fornecedor = produto[0].Fornecedor || '';
          this.quantidade = 0;
          this.calculateSubtotal();
  
          // Percorre todos os itens do carrinho para ajustar a quantidade de estoque
          this.cart.forEach(cartItem => {
            // Verifica se o código do produto do carrinho é igual ao código do produto carregado
            if (cartItem.code === this.ProdutoCode) {
              // Subtrai a quantidade do item no carrinho do estoque
              this.produtoEstoque -= cartItem.quantidade;
            }
          });
  
          // Se o estoque ficar negativo, ajusta para 0
          if (this.produtoEstoque < 0) {
            this.produtoEstoque = 0;
          }
  
        } else {
          this.limparCampos(false);
          this.ProdutoNome = '---';
          this.unitPrice = 0;
          this.produtoEstoque = 0;
          this.fornecedor =  '';
          this.quantidade = 0;
          this.calculateSubtotal();
        }
      },
      error: (err) => {
        console.error('Erro ao carregar produto:', err);
        this.limparCampos(false);
        this.ProdutoNome = '---';
          this.unitPrice = 0;
          this.produtoEstoque = 0;
          this.fornecedor =  '';
          this.quantidade = 0;
          this.calculateSubtotal();
      },
    });
  }
  

  // Método para adicionar ao carrinho
  addToCart() {
    if (!this.ProdutoNome || this.ProdutoNome === '---') {
      alert('Digite um código válido!');
      return;
    }
    if (!this.quantidade || this.quantidade <= 0) {
      alert('Quantidade inválida! \n\nSe a quantidade estiver nula no estoque, \nFaça a reposição!');
      return;
    }
  
    // Cria o objeto do produto com todas as informações
    const item = {
      code: this.ProdutoCode,
      name: this.ProdutoNome,
      quantidade: this.quantidade,
      unitPrice: this.unitPrice,
      subtotal: this.subtotal,
      fornecedor: this.fornecedor
    };
  
    // Verifica se o produto já está no carrinho
    const existingItemIndex = this.cart.findIndex(cartItem => cartItem.code === this.ProdutoCode);
  
    if (existingItemIndex !== -1) {
      // Se o produto já estiver no carrinho, atualiza a quantidade
      this.cart[existingItemIndex].quantidade += this.quantidade;
      // Atualiza o subtotal do item no carrinho (caso necessário)
      this.cart[existingItemIndex].subtotal = this.cart[existingItemIndex].quantidade * this.cart[existingItemIndex].unitPrice;
    } else {
      // Se o produto não estiver no carrinho, adiciona o item
      this.cart.push(item);
    }
  
    this.limparCampos(true);  // Limpa os campos
    this.discount = 0;  // Reseta o desconto
  }
  

  // Calcula o subtotal de um produto
  calculateSubtotal() {
    this.subtotal = this.quantidade * this.unitPrice;
  }

  limparCampos(full: boolean = true) {
    if (full) {
      // Limpa os campos do formulário e também a variável de controle do carrinho
      this.ProdutoCode = 0;
      this.ProdutoNome = '';
      this.quantidade = 0;
      this.unitPrice = 0;
      this.subtotal = 0;
      this.ListaDeProdutos = '';
      this.selectedPaymentMethods = '';
    }
    
    // Limpa o carrinho e o estado de pagamento
    this.paymentMethods = { credit: false, debit: false, cash: false, pix: false };
    this.produtoEstoque = 0;
  }
  

  // Método para remover produto do carrinho
  removeFromCart(index: number) {
    this.cart.splice(index);
    this.discount = 0;
    this.limparCampos();
  }

  // Calcula o total do carrinho
  getTotal() {
    return this.cart.reduce((total, item) => total + item.subtotal, 0);
  }

  // Aplica o desconto no total
  getTotalAfterDiscount() {
    const total = this.getTotal();
    return total - (total * this.discount) / 100;
  }

 // Confirma o pedido
 ConfirmarCadastro() {
  if (this.cart.length === 0) {
    alert('Carrinho vazio!');
    return;
  }

  const selectedMethods = [];
  if (this.paymentMethods.credit) selectedMethods.push('Crédito');
  if (this.paymentMethods.debit) selectedMethods.push('Débito');
  if (this.paymentMethods.cash) selectedMethods.push('Dinheiro');
  if (this.paymentMethods.pix) selectedMethods.push('Pix');

  if (selectedMethods.length === 0) {
    alert('Selecione pelo menos uma forma de pagamento!');
    return;
  }

  this.selectedPaymentMethods = selectedMethods.join(', ');

  this.atualizarEstoqueSubtracao();
  this.salvarRegistrarPedidoSaida();
  this.salvaRegistrarPedido();

  alert('Pedido confirmado!');
  this.cart = [];
  this.limparCampos(true);    
  window.location.reload();
  
}

salvarRegistrarPedidoSaida() {
  let i = 0; // Array para armazenar os produtos

  while (i < this.cart.length) {
    const item = this.cart[i];
    this.ListaDeProdutos += `${item.code} | ${item.name} | ${item.quantidade}X | ${this.formatoDinheiroDisplay(item.unitPrice)} | ${this.formatoDinheiroDisplay(item.subtotal)}\n`;
    // Dados para registrar o pedido de saída
    const novaRegistrarPedidoSaida = {
      Data: this.dataHoje,
      Produto: item.name,
      Fornecedor: item.fornecedor,
      Quantidade: item.quantidade,
      ValorDaVenda: item.subtotal - ((item.subtotal * this.discount) / 100)
    };

    // Chamada para salvar o pedido de saída
    this.RegistrarPedidoService.adicionarRegistrarPedidoSaida(novaRegistrarPedidoSaida).subscribe({
      error: (error) => {
        console.log('Erro ao registrar Pedido:', error);
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

    this.produtosService.atualizarEstoqueSubtracao(item.code, item.quantidade).subscribe({
      next: (response) => {
        
      },
      error: (err) => {
        console.error(`Erro ao atualizar estoque do produto ${item.name}: `, err);
      }
    });
    i++;
  }
}


salvaRegistrarPedido(){  
    const novaRegistrarPedido = {
    Data: this.dataHoje,
    ListaDeProdutos: this.ListaDeProdutos,  // Lista de produtos confirmados
    Desconto: this.discount,
    SubTotal: this.getTotal(),  // Subtotal numérico, sem formatação
    Total: this.getTotalAfterDiscount(),  // Total numérico, sem formatação
    FormaDePagamento: this.selectedPaymentMethods
  };
  this.RegistrarPedidoService.adicionarRegistrarPedido(novaRegistrarPedido).subscribe({
    error: (error) => {
      console.log('Erro ao registrar Pedido:', error);
      return;
    }
    
  });
}


cancelSale() {
  this.cart = [];
  this.limparCampos(false);  // Não limpa todos os campos, pois não estamos fazendo a confirmação do pedido
  alert('Pedido cancelado!');
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
}
