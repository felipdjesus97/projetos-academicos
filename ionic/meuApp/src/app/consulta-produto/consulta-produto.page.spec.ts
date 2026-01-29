import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ConsultaProdutoPage } from './consulta-produto.page';

describe('ConsultaProdutoPage', () => {
  let component: ConsultaProdutoPage;
  let fixture: ComponentFixture<ConsultaProdutoPage>;

  beforeEach(() => {
    fixture = TestBed.createComponent(ConsultaProdutoPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
