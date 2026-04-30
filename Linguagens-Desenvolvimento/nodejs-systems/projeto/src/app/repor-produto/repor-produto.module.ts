import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ReporProdutoPageRoutingModule } from './repor-produto-routing.module';

import { ReporProdutoPage } from './repor-produto.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ReporProdutoPageRoutingModule
  ],
  declarations: [ReporProdutoPage]
})
export class ReporProdutoPageModule {}
