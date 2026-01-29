import { Component } from '@angular/core';
import { MenuController } from '@ionic/angular';
import { fornecedoresService } from '../fornecedores.service'; 
import { AlertController } from '@ionic/angular';
import { Router } from '@angular/router';
import { NavController } from '@ionic/angular';

@Component({
  selector: 'app-consulta-fornecedor',
  templateUrl: './consulta-fornecedor.page.html',
  styleUrls: ['./consulta-fornecedor.page.scss'],
})
export class ConsultaFornecedorPage {
  searchTerm: string = '';
  allFornecedors: any[] = [];  // Todos os fornecedores
  filteredFornecedors: any[] = [];  // Fornecedores filtrados
  fornecedorCode: number = 0;
  selectedItem: string = '';
  showMore: boolean = false;  // Controle para saber se mostrar mais fornecedores

  constructor(
    private nav: NavController,
    private menu: MenuController,
    private fornecedoresService: fornecedoresService, // Serviço de fornecedores
    private alertController: AlertController,
    private router: Router
  ) {}

  ngOnInit() {
    this.listarFornecedors(); // Carrega todos os fornecedores na inicialização
  }

  // Função para filtrar fornecedores
  filterFornecedors() {
    if (this.searchTerm.trim() === '') {
      this.listarFornecedors(); // Se não digitar nada, lista todos os fornecedores
    } else {
      this.fornecedoresService.listarfornecedoresPorNome(this.searchTerm).subscribe(data => {
        this.allFornecedors = data;
        this.filteredFornecedors = this.allFornecedors.slice(0, 5); // Exibe apenas os primeiros 5
        this.showMore = this.allFornecedors.length > 5; // Verifica se há mais de 5 resultados
      });
    }
  }

  // Função para carregar fornecedores
  listarFornecedors() {
    this.fornecedoresService.listarfornecedores().subscribe(data => {
      this.allFornecedors = data;
      this.filteredFornecedors = this.allFornecedors.slice(0, 5); // Exibe os primeiros 5
      this.showMore = this.allFornecedors.length > 5; // Verifica se há mais de 5 resultados
    });
  }

  // Função para carregar mais fornecedores
  loadMore() {
    const currentLength = this.filteredFornecedors.length;
    const newResults = this.allFornecedors.slice(currentLength, currentLength + 5);
    this.filteredFornecedors = [...this.filteredFornecedors, ...newResults];
    this.showMore = this.filteredFornecedors.length < this.allFornecedors.length; // Verifica se há mais fornecedores
  }

  openMenu() {
    this.menu.open('first'); // Abre o menu
  }

  // Função para editar o fornecedor baseado no código
  async editFornecedor() {
    if (!this.fornecedorCode) {
      const alert = await this.alertController.create({
        header: 'Erro',
        message: 'Por favor, insira um código de fornecedor.',
        buttons: ['OK']
      });
      await alert.present();
      return;
    }

    const fornecedor = this.filteredFornecedors.find(f => f.Codigo === this.fornecedorCode);
    if (fornecedor) {
      const alert = await this.alertController.create({
        header: 'Editar Fornecedor',
        message: `Você está editando o fornecedor: ${fornecedor.Nome}`,
        buttons: ['OK']
      });
      await alert.present();
    } else {
      const alert = await this.alertController.create({
        header: 'Fornecedor não encontrado',
        message: 'Fornecedor com o código informado não encontrado.',
        buttons: ['OK']
      });
      await alert.present();
    }
  }

  async deleteFornecedor() {
    if (!this.fornecedorCode) {
      const alert = await this.alertController.create({
        header: 'Erro',
        message: 'Por favor, insira um código de fornecedor.',
        buttons: ['OK']
      });
      await alert.present();
      return;
    }

    const confirmAlert = await this.alertController.create({
      header: 'Confirmar Exclusão',
      message: `Tem certeza que deseja excluir o fornecedor com código ${this.fornecedorCode}?`,
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
            this.fornecedoresService.deletarfornecedor(this.fornecedorCode).subscribe(
              async (response: any) => {
                const alert = await this.alertController.create({
                  header: 'Sucesso',
                  message: 'Fornecedor excluído com sucesso!',
                  buttons: ['OK']
                });
                await alert.present();
                this.listarFornecedors(); // Atualiza a lista de fornecedores após a exclusão
              },
              async (error: any) => {
                const alert = await this.alertController.create({
                  header: 'Erro',
                  message: 'Erro ao excluir fornecedor. Tente novamente mais tarde.',
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

  // Função para cadastrar um novo fornecedor (em desenvolvimento)
  addFornecedor() {
    this.router.navigate(['/cadastro-fornecedor']);
    this.selectedItem = '/cadastro-fornecedor';
  }
}
