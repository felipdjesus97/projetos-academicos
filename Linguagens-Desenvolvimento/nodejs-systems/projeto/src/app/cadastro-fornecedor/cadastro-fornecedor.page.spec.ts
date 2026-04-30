import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CadastroFornecedorPage } from './cadastro-fornecedor.page';

describe('CadastroFornecedorPage', () => {
  let component: CadastroFornecedorPage;
  let fixture: ComponentFixture<CadastroFornecedorPage>;

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastroFornecedorPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
