import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { CaixaPageRoutingModule } from './caixa-routing.module';

import { CaixaPage } from './caixa.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    CaixaPageRoutingModule
  ],
  declarations: [CaixaPage]
})
export class CaixaPageModule {}
