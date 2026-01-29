import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', loadChildren: () => import('./login/login.module').then(m => m.LoginPageModule) },
  { path: 'caixa', loadChildren: () => import('./caixa/caixa.module').then(m => m.CaixaPageModule) },
  { path: 'cadastro-fornecedor', loadChildren: () => import('./cadastro-fornecedor/cadastro-fornecedor.module').then(m => m.CadastroFornecedorPageModule) },
  { path: 'consulta-fornecedor', loadChildren: () => import('./consulta-fornecedor/consulta-fornecedor.module').then(m => m.ConsultaFornecedorPageModule) },
  { path: 'cadastro-produto', loadChildren: () => import('./cadastro-produto/cadastro-produto.module').then(m => m.CadastroProdutoPageModule) },
  { path: 'consulta-produto', loadChildren: () => import('./consulta-produto/consulta-produto.module').then(m => m.ConsultaProdutoPageModule) },
  { path: 'repor-produto', loadChildren: () => import('./repor-produto/repor-produto.module').then(m => m.ReporProdutoPageModule) },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })],
  exports: [RouterModule]
})
export class AppRoutingModule {}
