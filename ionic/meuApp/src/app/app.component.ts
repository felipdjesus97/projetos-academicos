import { Component } from '@angular/core';
import { MenuController, NavController } from '@ionic/angular';
import { Router, NavigationEnd } from '@angular/router';  // Certifique-se de importar corretamente
import { filter } from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss'],
})
export class AppComponent {
  selectedItem: string = '';

  constructor(private Menu: MenuController, private nav: NavController, private router: Router) {
    // Observa as mudanças de navegação e garante que o tipo 'event' seja tratado como 'NavigationEnd'
    this.router.events.pipe(
      filter((event): event is NavigationEnd => event instanceof NavigationEnd)  // Usamos um predicado para garantir que o tipo seja NavigationEnd
    ).subscribe((event) => {
      this.selectedItem = event.urlAfterRedirects;  // Atualiza a seleção do item com a URL atual
    });
  }

  fecharMenu() {
    this.Menu.close();
  }

  navegar(url: string) {
    this.selectedItem = url;  // Define o item selecionado
    this.nav.navigateRoot(url);
  }

  sair() {
    this.nav.navigateRoot('/login');  // Redireciona para a página de Login
  }
}
