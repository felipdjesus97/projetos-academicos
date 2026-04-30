import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class ProdutosService {
    private apiUrl = 'http://localhost:3000/produto'; // Atualizado para a rota correta

    constructor(private http: HttpClient) {}

    adicionarProduto(produto: any, file: File | null): Observable<any> {
        const formData = new FormData();
        formData.append('Nome', produto.Nome);
        formData.append('Quantidade', produto.Quantidade.toString());
        formData.append('Fornecedor', produto.Fornecedor);
        formData.append('QuantidadeMinima', produto.QuantidadeMinima.toString());
        formData.append('PrecoUnitario', produto.PrecoUnitario.toString());
        if (file) {
            formData.append('Imagem', file, file.name);
        }

        return this.http.post(this.apiUrl, formData);
    }

    atualizarEstoqueSubtracao(codigo: number, quantidade: number): Observable<any> {
        return this.http.put(`${this.apiUrl}/${codigo}/atualizarEstoqueSubtracao`, { quantidade });
    }
    atualizarEstoqueSoma(codigo: number, quantidade: number): Observable<any> {
        return this.http.put(`${this.apiUrl}/${codigo}/atualizarEstoqueSoma`, { quantidade });
    }
    listarProdutosPorNome(nome: string): Observable<any> {
        return this.http.get<any>(`${this.apiUrl}?nome=${nome}`);
    }
    listarProdutosPorCodigo(codigo: number): Observable<any> {
        return this.http.get<any>(`${this.apiUrl}?codigo=${codigo}`);
      }
      listarProdutosPorCodigoFornecedor(codigo: number, fornecedor: string): Observable<any> {
        return this.http.get<any>(`${this.apiUrl}?codigo=${codigo}&fornecedor=${fornecedor}`);
    }
    
    listarProdutos(): Observable<any> {
        return this.http.get(this.apiUrl); 
    }
 
    deletarProduto(id: number): Observable<any> {
        return this.http.delete(`${this.apiUrl}/${id}`);
      }
      getFornecedores(): Observable<string[]> {
        return this.http.get<string[]>('http://localhost:3000/fornecedores');
    }
}
