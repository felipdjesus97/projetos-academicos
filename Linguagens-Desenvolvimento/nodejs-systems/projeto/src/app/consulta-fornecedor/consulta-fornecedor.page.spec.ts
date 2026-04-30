import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ConsultaFornecedorPage } from './consulta-fornecedor.page';

describe('ConsultaFornecedorPage', () => {
  let component: ConsultaFornecedorPage;
  let fixture: ComponentFixture<ConsultaFornecedorPage>;

  beforeEach(() => {
    fixture = TestBed.createComponent(ConsultaFornecedorPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
