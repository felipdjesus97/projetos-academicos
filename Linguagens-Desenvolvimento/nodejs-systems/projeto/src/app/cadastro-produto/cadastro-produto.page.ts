import { Component } from '@angular/core';
import { MenuController } from '@ionic/angular';
import { ProdutosService } from '../produtos.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-cadastro-produto',
    templateUrl: './cadastro-produto.page.html',
    styleUrls: ['./cadastro-produto.page.scss'],
})
export class CadastroProdutoPage {
    ProdutoNome: string = '';
    quantidade: number = 0;
    fornecedor: string = '';
    QuantidadeMinima: number = 0;
    formatoprecoUnitario: string = '0,00';
    selectedFile: File | null = null;
    imagePreview: string = '../assets/padrao.jpg'; // Caminho padrão da imagem

    fornecedores: any[] = []; // Agora vamos armazenar os fornecedores aqui

    constructor(
        private menu: MenuController, 
        private router: Router, 
        private produtosService: ProdutosService
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

    onFileSelected(event: Event) {
        const input = event.target as HTMLInputElement;
        if (input.files && input.files.length > 0) {
            this.selectedFile = input.files[0];
            const reader = new FileReader();
            reader.onload = (e) => {
                this.imagePreview = e.target?.result as string; // Atualiza a imagem para visualização
            };
            reader.readAsDataURL(this.selectedFile);
        }
    }

    addProduto() {
        const precoUnitario = this.converterNumero(this.formatoprecoUnitario);
        
        const novoProduto = {
            Nome: this.ProdutoNome,
            Quantidade: this.quantidade,
            Fornecedor: this.fornecedor,
            QuantidadeMinima: this.QuantidadeMinima,
            PrecoUnitario: precoUnitario
        };

        this.produtosService.adicionarProduto(novoProduto, this.selectedFile).subscribe(() => {
            console.log('Produto cadastrado:', novoProduto);
            alert('Cadastro confirmado!');
            this.limparCampos();
        }, (error) => {
            console.error('Erro ao cadastrar produto:', error);
            alert('Erro ao cadastrar o produto. ');
        });
    }

    formatoDinheiro() {
        const precoUnitario = this.converterNumero(this.formatoprecoUnitario);
        this.formatoprecoUnitario = precoUnitario.toLocaleString('pt-BR', { minimumFractionDigits: 2, maximumFractionDigits: 2 });
    }

    converterNumero(value: string): number {
        return parseFloat(value.replace(/\./g, '').replace(',', '.'));
    }

    limparCampos() {
        this.ProdutoNome = '';
        this.quantidade = 0;
        this.fornecedor = '';
        this.QuantidadeMinima = 0;
        this.formatoprecoUnitario = '0,00';
        this.selectedFile = null; // Limpar o arquivo selecionado
        this.imagePreview = '../assets/padrao.jpg'; // Resetar a imagem para padrão
    }
    
    ConfirmarCadastro() {
        this.addProduto();
    }
}
