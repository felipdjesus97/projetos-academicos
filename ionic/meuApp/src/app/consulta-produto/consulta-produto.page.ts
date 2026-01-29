import { Component } from '@angular/core';
import { MenuController } from '@ionic/angular';
import { ProdutosService } from '../produtos.service';
import { AlertController } from '@ionic/angular';
import { Router } from '@angular/router';
import { NavController } from '@ionic/angular';

@Component({
  selector: 'app-consulta-produto',
  templateUrl: './consulta-produto.page.html',
  styleUrls: ['./consulta-produto.page.scss'],
})
export class ConsultaProdutoPage {
  searchTerm: string = '';
  allProdutos: any[] = [];  // Todos os produtos
  filteredProdutos: any[] = [];  // Produtos filtrados
  ProdutoCode: number = 0;
  selectedItem: string = '';
  showMore: boolean = false;  // Controle de exibição do botão "Carregar mais"

  constructor(
    private nav: NavController,
    private menu: MenuController,
    private produtosService: ProdutosService,
    private alertController: AlertController,
    private router: Router
  ) {}

  ngOnInit() {
    this.listarProdutos(); // Carrega todos os produtos na inicialização
  }

  // Função de navegação
  navegar(url: string) {
    this.selectedItem = url;
    this.nav.navigateRoot(url);
  }

  // Função para filtrar produtos
  filterProdutos() {
    if (this.searchTerm.trim() === '') {
      this.listarProdutos(); // Se não digitar nada, lista todos os produtos
    } else {
      this.produtosService.listarProdutosPorNome(this.searchTerm).subscribe(data => {
        this.allProdutos = data;
        this.filteredProdutos = this.allProdutos.slice(0, 5); // Exibe apenas os primeiros 5 produtos
        this.showMore = this.allProdutos.length > 5; // Verifica se há mais de 5 produtos
      });
    }
  }

  // Função para listar todos os produtos
  listarProdutos() {
    this.produtosService.listarProdutos().subscribe(data => {
      this.allProdutos = data;
      this.filteredProdutos = this.allProdutos.slice(0, 5); // Exibe os primeiros 5 produtos
      this.showMore = this.allProdutos.length > 5; // Verifica se há mais de 5 produtos
    });
  }

  // Função para carregar mais produtos
  loadMore() {
    const currentLength = this.filteredProdutos.length;
    const newResults = this.allProdutos.slice(currentLength, currentLength + 5);
    this.filteredProdutos = [...this.filteredProdutos, ...newResults];
    this.showMore = this.filteredProdutos.length < this.allProdutos.length; // Verifica se há mais produtos
  }

  // Função para abrir o menu
  openMenu() {
    this.menu.open('first');
  }

  // Função para editar um produto (ainda não implementada)
  editProduto() {
    // Lógica de edição (em desenvolvimento)
  }

  // Função para excluir um produto
  async deleteProduto() {
    if (!this.ProdutoCode) {
      const alert = await this.alertController.create({
        header: 'Erro',
        message: 'Por favor, insira um código de produto.',
        buttons: ['OK']
      });
      await alert.present();
      return;
    }

    // Confirmar a exclusão
    const confirmAlert = await this.alertController.create({
      header: 'Confirmar Exclusão',
      message: `Tem certeza que deseja excluir o produto com código ${this.ProdutoCode}?`,
      buttons: [
        {
          text: 'Cancelar',
          role: 'cancel',
          handler: () => {
            console.log('Cancelado');
          }
        },
        {
          text: 'Confirmar',
          handler: () => {
            this.produtosService.deletarProduto(this.ProdutoCode).subscribe(
              async (response: any) => {
                const alert = await this.alertController.create({
                  header: 'Sucesso',
                  message: 'Produto excluído com sucesso!',
                  buttons: ['OK']
                });
                await alert.present();
                this.listarProdutos(); // Atualiza a lista de produtos após a exclusão
              },
              async (error: any) => {
                const alert = await this.alertController.create({
                  header: 'Erro',
                  message: 'Erro ao excluir produto. Tente novamente mais tarde.',
                  buttons: ['OK']
                });
                await alert.present();
              }
            );
          }
        }
      ]
    });

    await confirmAlert.present();
  }

  // Função para cadastrar um novo produto
  addProduto() {
    this.router.navigate(['/cadastro-produto']);
    this.selectedItem = '/cadastro-produto'; 
  }
}
