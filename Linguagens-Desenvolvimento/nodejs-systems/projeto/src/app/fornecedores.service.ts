import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class fornecedoresService {
    private apiUrl = 'http://localhost:3000/fornecedor'; // Atualizado para a rota correta

    constructor(private http: HttpClient) {}

    adicionarfornecedor(fornecedor: any): Observable<any> {
        return this.http.post(this.apiUrl, fornecedor);
    }

    listarfornecedoresPorNome(nome: string): Observable<any> {
        return this.http.get<any>(`${this.apiUrl}?nome=${nome}`);
    }
    listarfornecedores(): Observable<any> {
        return this.http.get(this.apiUrl); 
    }
 
    deletarfornecedor(id: number): Observable<any> {
        return this.http.delete(`${this.apiUrl}/${id}`);
    }

    

}
