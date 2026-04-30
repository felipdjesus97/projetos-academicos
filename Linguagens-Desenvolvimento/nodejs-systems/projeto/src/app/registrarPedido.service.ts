import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class RegistrarPedidoService {
    private apiUrl = 'http://localhost:3000/registrarPedido'; // Atualizado para a rota correta

    constructor(private http: HttpClient) {}

    adicionarRegistrarPedidoSaida(registrarPedido: any): Observable<any> {
        return this.http.post(this.apiUrl+'Saida', registrarPedido);
    }
    adicionarRegistrarPedido(registrarPedido: any): Observable<any> {
        return this.http.post(this.apiUrl, registrarPedido);
    }
    
}
