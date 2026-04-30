#include "iostream"
#include "cstdlib"
#include "math.h"
#include "conio.h"
#include "iomanip"
#include "windows.h"
#include "locale.h"
using namespace std;

double p,v,ta,te,a,b,vo,co,la,al,c;
double vetpos[4];
double soma=0, mult=0;
string vettex[4] = {"A", "B", "C", "D"};
int num,res;
int main(){
     setlocale(LC_ALL, "Portuguese");
     char tecla = '0';
     while (tecla != 27){
     cout<<"MENU \
     \n1 - Prestação: \
     \n2 - Trocar valores: \
     \n3 - Adição e multiplicação: \
     \n4 - Volume da caixa retangular: \
     \n5 - Resultado quadrado \
     \nESC para sair:";
     tecla = getch();
     system("cls");
     if(tecla=='1'){
         cout << "Digite o valor:";
         cin >> v;
         cout << "Digite a taxa:";
         cin >> ta;
         cout << "Digite o tempo:";
         cin >> te;
         p = v +(v *(ta/100)*te);
         cout << "O valor da prestação é: " << p << endl;
     }else if(tecla=='2'){
         cout << "Digite o valor A:";
         cin >> a;
         cout << "Digite o valor B:";
         cin >> b;
          c = a;
          a = b;
          b = c;
          cout << "Valores trocados - A: " << a << " e B: " << b <<endl;
     }else if(tecla=='3'){
         cout << "Digite o valor A:";
         cin >> vetpos[0];
         cout << "Digite o valor B:";
         cin >> vetpos[1];
         cout << "Digite o valor C:";
         cin >> vetpos[2];
         cout << "Digite o valor D:";
         cin >> vetpos[3];
         int temp, cont;
         temp=0;
         cont=1;
         while(temp<4){
                       while(cont<4){
                       soma = vetpos[temp] + vetpos[cont];
                       mult = vetpos[temp] * vetpos[cont];
                       cout << "Valor de (" << vettex[temp] << "+" << vettex[cont] << ") " << vetpos[temp] << " + "<< vetpos[cont] <<" = "
                        << soma << " e ("  << vettex[temp] << "x" << vettex[cont] << ") " << vetpos[temp] << " x "<< vetpos[cont] <<" = " << mult << ";\n";
                       cont ++;
                       }
         temp ++;
         cont = temp +1;
         }            
     }else if(tecla=='4'){
         cout << "Digite o compromento:";
         cin >> co;
         cout << "Digite a largura:";
         cin >> la;
         cout << "Digite a altura:";
         cin >> al;
         vo = co * la * al;
         cout<< "Volume da caixa = " << vo;    
     }else if(tecla=='5'){
         cout << "Digite número inteiro:";
         cin >> num;
         res = num * num;
         cout<< num <<"² = "<< res;
     }
     system("pause");
     system("cls");
     }
     return 0;
}
     
