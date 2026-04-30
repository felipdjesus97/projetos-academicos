import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../login.service'; 

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage {
  usuario: string = '';
  senha: string = '';

  constructor(private router: Router, private loginService: LoginService) {}
  onKeyDown(event: KeyboardEvent) {
    if (event.key === 'Enter') {
      this.login();
    }
  }
  // Função de login
  login() {
    this.loginService.authenticate(this.usuario, this.senha).subscribe(
      (response) => {
        console.log('Login bem-sucedido', response);
        this.router.navigate(['/caixa']); // Redireciona após login bem-sucedido
        this.limparCampos();
      },
      (error) => {
        alert('Usuário ou Senha Inválidos.');
        this.limparCampos();
        console.log('Erro de login:', error);
      }
    );
  }
  limparCampos(){
    this.usuario = '';
          this.senha = '';
  }
}

