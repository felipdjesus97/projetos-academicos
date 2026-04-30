#include "iostream"
#include "cstdlib"
#include "math.h"
#include "string.h"
#include "conio.h"
using namespace std;

int main (){  
    setlocale(LC_ALL, "Portuguese");
    double peso, altura, imc;
    string clas;
    char tecla = '0';
    while (tecla != 27){
        system("cls");
        cout << "\n1 - Ler Peso e Altura \
                 \n2 - Efetuar cálculos \
                 \n3 - Exibir resultados \
                 \nESC - sair\n";
        tecla = getch(); // captura a tecla     
        if(tecla == '1'){
              system("cls");
              cout << "\nDigite o peso:";
              cin >> peso;             
              cout << "\nDigite o altura:";
              cin >> altura;
        }else if (tecla == '2'){  
            imc = peso/ pow(altura, 2);
            if (imc <= 18.4){
                 clas = "Abaixo do peso..."; 
             }else if (imc >= 18.5 && imc <= 24.9 ){               
                 clas = "Normal..."; 
             }else if (imc >= 25 && imc <= 29.9 ){               
                 clas = "Sobre peso..."; 
             }else if (imc >= 30 && imc <= 34.9 ){
                 clas = "Obesidade grau I"; 
             }else if (imc >= 35 && imc <= 39.9 ){
                 clas = "Obesidade grau II";
             }else{
                 clas = "Obesidade grau III"; 
                 cout << "cálculos efetuados...!";        
                 system("pause");
                 }
        }else if (tecla == '3'){
             cout << "\nTela de Saída\n";
             cout << "\nIMC:" << imc ;
             cout << "\nClassificação:" << clas;             
             cout << "\nFim da saída\n";
             system("pause");
         }
    }
    return 0; }
