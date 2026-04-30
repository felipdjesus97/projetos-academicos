import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class ReporProdutoService {
    private apiUrl = 'http://localhost:3000/reporProduto'; // Atualizado para a rota correta

    constructor(private http: HttpClient) {}

    adicionarReporProdutoEntrada(reporProduto: any): Observable<any> {
        return this.http.post(this.apiUrl+'Entrada', reporProduto);
    }
    adicionarReporProduto(reporProduto: any): Observable<any> {
        return this.http.post(this.apiUrl, reporProduto);
    }
    
}
