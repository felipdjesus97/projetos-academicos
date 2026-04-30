import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class LoginService {
  private apiUrl = 'http://localhost:3000/login'; // Endpoint para autenticação

  constructor(private http: HttpClient) {}

  // Método para autenticar o usuário
  authenticate(usuario: string, senha: string): Observable<any> {
    const body = { usuario, senha }; // Envia os dados de login
    return this.http.post<any>(this.apiUrl, body); // Chama a API
  }
}
