
package com.mycompany.lista7;

public class Superior{
    private  double n1,n2,n3, media;
    public double CalculaMedia(boolean tipo){
        if (tipo == true) {
            media = (n1*0.35 + n2*0.5 + n3*0.15); 
        }else if(tipo == false){
            media = (n1 + n2*2 + n3*2)/5;
        }       
        return media;
    }
    private void inserirN1(double a){
        this.n1 = a;
    }
    private void inserirN2(double a){
        this.n2 = a;
    }
    private void inserirN3(double a){
        this.n3 = a;
    }
    Superior(double nota1,double nota2,double nota3){
        inserirN1(nota1);
        inserirN2(nota2);
        inserirN3(nota3); 
    }
}
