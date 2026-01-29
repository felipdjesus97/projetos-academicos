import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ReporProdutoPage } from './repor-produto.page';

describe('ReporProdutoPage', () => {
  let component: ReporProdutoPage;
  let fixture: ComponentFixture<ReporProdutoPage>;

  beforeEach(() => {
    fixture = TestBed.createComponent(ReporProdutoPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
