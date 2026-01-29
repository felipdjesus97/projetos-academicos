import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ConsultaFornecedorPage } from './consulta-fornecedor.page';

const routes: Routes = [
  {
    path: '',
    component: ConsultaFornecedorPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ConsultaFornecedorPageRoutingModule {}
