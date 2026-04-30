#include "iostream"
#include "cstdlib"
#include "math.h"
#include "conio.h"
#include "windows.h"
using namespace std;

struct media{
       double va,vb,me;
       }med[5];
       
double lerA(){
       double a; cout<<"A:";cin>>a;
       return a;
       }
double lerB(){
       double b; cout<<"B:";cin>>b;
       return b;
       }
double calmed(double a, double b){
       return sqrt(a*b);       
       }
int arm_media(int lin, double a, double b, double md){
    med[lin].va = a;
    med[lin].vb = b;
    med[lin].me = md;
    return 0;
    }
int exibir(double a, double b, double md){
    cout<<"Valor de A = "<<a;
    cout<<"\nValor de B = "<<b;
    cout<<"\nMédia = "<<md<<"\n\n";
    system("pause");
    return 0;
    }
int exibir_me(int lin){
    for(int i=0; i<=lin;i++){
            cout<<"Strut "<<i+1<<":";
            cout<<"\nValor de A = "<<med[i].va;
            cout<<"\nValor de B = "<<med[i].vb;
            cout<<"\nMédia = "<<med[i].me<<"\n\n";
            }
    system("pause");
    return 0;
    }
int main(){
    setlocale(LC_ALL, "Portuguese");
    int lin=-1, tecla=0;
    double a,b,md;
    while (tecla != 27){
          system("cls");
          cout << "1 - Ler valores";
          cout << "\n2 - Calcular dados";
          cout << "\n3 - Exibir média atual";
          cout << "\n4 - Exibir total de médias";
          cout << "\nESC - Sair\n";
          tecla = getch();
          system("cls");
                 if(tecla == '1'){
                          a= lerA();
                          b= lerB();
                 }else if(tecla == '2'){
                          md = calmed(a,b);
                          lin++;
                          arm_media(lin,a,b,md);
                          for(int i=0; i<=10;i++){
                          cout<<"calculando... "<<i<<"0%";
                          Sleep(100);system("cls");
                          }
                 }else if(tecla == '3'){
                          exibir(a,b,md);
                 }else if(tecla == '4'){
                          exibir_me(lin);
                 }
          }   
    }
