
package com.mycompany.lista5;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

public class Pessoa {
    int dia, mes,ano, idade;
    String nome;

    public void calculaIdade(){
        LocalDate hj = LocalDate.now();
        LocalDate Data = LocalDate.of(ano,mes,dia);
        int diferencaAnos = (int) ChronoUnit.YEARS.between(Data, hj);
        idade = diferencaAnos;       
    }
    public int informaIdade(){
        return idade;
    }
    public String informaNome(){
     return nome;   
    }
    public void inserirNome(String n){
        nome= n;
    }
    public void ajustaDataDeNascimento(int d,int m,int a){
        dia = d;
        mes = m;
        ano = a;
    }
}
