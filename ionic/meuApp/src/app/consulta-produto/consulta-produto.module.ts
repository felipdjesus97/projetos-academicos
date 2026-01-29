import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ConsultaProdutoPageRoutingModule } from './consulta-produto-routing.module';

import { ConsultaProdutoPage } from './consulta-produto.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ConsultaProdutoPageRoutingModule
  ],
  declarations: [ConsultaProdutoPage]
})
export class ConsultaProdutoPageModule {}
