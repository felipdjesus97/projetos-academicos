import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ConsultaProdutoPage } from './consulta-produto.page';

const routes: Routes = [
  {
    path: '',
    component: ConsultaProdutoPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ConsultaProdutoPageRoutingModule {}
