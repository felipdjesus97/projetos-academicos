import { Component } from '@angular/core';
import { MenuController } from '@ionic/angular';

import { fornecedoresService } from '../fornecedores.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-cadastro-fornecedor',
  templateUrl: './cadastro-fornecedor.page.html',
  styleUrls: ['./cadastro-fornecedor.page.scss'],
})
export class CadastroFornecedorPage {
  Nome: string = '';
  CPFCNPJ: string = '';
  Insta: string = '';
  Whats: string = '';
  Site: string = '';
  Endereco: string = '';
  Numero: string = '';
  Cidade: string = '';
  CEP: string = '';
  Obs: string = '';


  constructor(
    private menu: MenuController, 
    private router: Router, 
    private fornecedoresService: fornecedoresService
) {}

  openMenu() {
    this.menu.open('first');
  }

  addFornecedor() {
    
      if (
        !this.Nome ||
        !this.CPFCNPJ
      ) {
        alert('Por favor, preencha todos os campos obrigatórios!');
        return;
      }
  
      const novofornecedor = {
        Nome: this.Nome,
        Insta: this.Insta,
        Whats: this.Whats,
        Site: this.Site,
        Endereco: this.Endereco,
        Numero: this.Numero,
        Cidade: this.Cidade,
        CEP: this.CEP,
        Obs: this.Obs,
        CPFCNPJ: this.CPFCNPJ
      };
  this.fornecedoresService.adicionarfornecedor(novofornecedor).subscribe(() => {
    console.log('fornecedor cadastrado:', novofornecedor);
      alert('Cadastro confirmado!');
      this.limparCampos();
  }, (error) => {
      console.error('Erro ao cadastrar fornecedor:', error);
      alert('Erro ao cadastrar o fornecedor. ');
  });
  }
  formatarCPFCNPJ() {
    let valor = this.CPFCNPJ.replace(/\D/g, ''); // Remove tudo o que não for número

    // Formatar CPF (11 dígitos)
    if (valor.length <= 11) {
      this.CPFCNPJ = `${valor.slice(0, 3)}.${valor.slice(3, 6)}.${valor.slice(6, 9)}-${valor.slice(9, 11)}`;
    }
    // Formatar CNPJ (14 dígitos)
    else if (valor.length <= 14) {
      this.CPFCNPJ = `${valor.slice(0, 2)}.${valor.slice(2, 5)}.${valor.slice(5, 8)}/${valor.slice(8, 12)}-${valor.slice(12, 14)}`;
    }
  }
  formatWhatsApp() {
    this.Whats = this.Whats.replace(/\D/g, ''); // Remove caracteres não numéricos
    if (this.Whats.length > 10) {
      this.Whats = `(${this.Whats.slice(0, 2)}) ${this.Whats.slice(2, 7)}-${this.Whats.slice(7, 11)}`;
    }
  }
  formatCEP() {
    this.CEP = this.CEP.replace(/\D/g, ''); // Remove caracteres não numéricos
    if (this.CEP.length > 5) {
      this.CEP = `${this.CEP.slice(0, 5)}-${this.CEP.slice(5, 8)}`;
    } 
  }
  
  

  limparCampos() {
    this.Nome = '';
    this.Insta = '';
    this.Whats = '';
    this.Site = '';
    this.Endereco = '';
    this.Numero = '';
    this.Cidade = '';
    this.CEP = '';
    this.Obs = '';
    this.CPFCNPJ='';
  }
  ConfirmarCadastro() {
    this.addFornecedor();
  }
}
