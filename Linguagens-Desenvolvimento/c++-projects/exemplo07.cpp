#include "iostream"
#include "cstdlib"
#include "math.h"
#include "conio.h"
#include "windows.h"
using namespace std;

struct media{
       double va,vb,vc,vx1,vx2;
       }med[5];
       
double lerA(){
       double a; cout<<"A:";cin>>a;
       return a;
       }
double lerB(){
       double b; cout<<"B:";cin>>b;
       return b;
       }
double lerC(){
       double c; cout<<"C:";cin>>c;
       return c;
       }
double calc(double a, double b, double c){
	   double d = pow(b,2)-4*a*c;
	   return d;
}
double x1(double a, double b, double d){
	   double x = (-b + sqrt(d))/2*a;
       return x;
}
double x2(double a, double b, double d){
	   double x = (-b - sqrt(d))/2*a;
       return x;
}
int arm_equa(int lin, double a, double b, double c, double x1, double x2){
    med[lin].va = a;
    med[lin].vb = b;
    med[lin].vc = c;
	med[lin].vx1 = x1;
    med[lin].vx2 = x2;
	return 0;
    }
int exibir(double a, double b, double c, double x1, double x2){
    cout<<a<<"x² + ("<<b<<")x + ("<<c<<") = 0 portanto x1= "<<x1<<", x2= "<<x2<<"\n\n";
    system("pause");
    return 0;
    }
int exibir_equa(int lin){
    for(int i=0; i<=lin;i++){
            cout<<"Equação "<<i+1<<":\n";
            cout<<med[i].va<<"x² + ("<<med[i].vb<<")x + ("<<med[i].vc<<") = 0 portanto x1= "<<med[i].vx1<<", x2= "<<med[i].vx2<<"\n\n";
            }
    system("pause");
    return 0;
    }
int main(){
    setlocale(LC_ALL, "Portuguese");
    int lin=-1, tecla=0;
    double a,b,c,delta,dx1, dx2;
    while (tecla != 27){
          system("cls");
          cout << "1 - Ler valores";
          cout << "\n2 - Calcular dados";
          cout << "\n3 - Exibir equação";
          cout << "\n4 - Exibir todas equações";
          cout << "\nESC - Sair\n";
          tecla = getch();
          system("cls");
                 if(tecla == '1'){
                          a= lerA();
                          b= lerB();
                          c= lerC();
                 }else if(tecla == '2'){
                          delta = calc(a,b,c);
                          dx1 = x1(a,b,delta);
                          dx2 = x2(a,b,delta);
						  lin++;
                          arm_equa(lin,a,b,c,dx1,dx2);
                          for(int i=0; i<=10;i++){
                          cout<<"calculando... "<<i<<"0%";
                          Sleep(100);system("cls");
                          }
                 }else if(tecla == '3'){
                          exibir(a,b,c,dx1,dx2);
                 }else if(tecla == '4'){
                          exibir_equa(lin);
                 }
          }   
    }
