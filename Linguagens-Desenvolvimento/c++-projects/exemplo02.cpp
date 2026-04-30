#include "iostream"
#include "cstdlib"
#include "math.h"
#include "string.h"
#include "conio.h"
using namespace std;

int main (){
    setlocale(LC_ALL, "Portuguese");
    char tecla = '0';
    string text;
    double celsius, fahrenheit, altura, volume, raio, distancia, tempo, velocidade, litros;
    
    while (tecla != 27){
          system("cls");
          cout << "\n1 - Converter de Celsius em Fahrenheit \
                 \n2 - Converter de Fahrenheit em Celsius \
                 \n3 - Calcular volume da lata\
                 \n4 - Quantidade de litros gastos em uma viagem\
                 \nESC - sair\n";
                 tecla = getch(); // captura a tecla
                 
                 if(tecla == '1'){
                 system("cls");
                 cout << "\nDigite graus Celsius:\n";
                 cin >> celsius;
                 system("cls");
                 fahrenheit = (9 * celsius + 160) /5;
                 cout << "\nº" << celsius << " graus Celsius = º"<<fahrenheit <<" graus Fahrenheit \n\n";
                 system("pause");
                 
                 }else if(tecla == '2'){
                 system("cls");
                 cout << "\nDigite graus Fahrenheit:\n";
                 cin >> fahrenheit;
                 system("cls");
                 celsius = (fahrenheit - 32) * 5/9;
                 cout << "\nº" << fahrenheit << " graus Fahrenheit = º"<<celsius <<" graus Celsius \n\n";
                 system("pause");
                 
                 }else if(tecla == '3'){
                 system("cls");
                 cout << "\nDigite a altura da lata:\n";
                 cin >> altura;
                 system("cls");
                 cout << "\nDigite a raio da lata:\n";
                 cin >> raio;
                 system("cls");
                 volume = 3.14159 * pow(raio, 2) * altura;
                 cout << "\nVolume = " << volume <<"\n\n";
                 system("pause");
                 
                 }else if(tecla == '4'){
                 system("cls");
                 cout << "\nDigite tempo gasto de viagem:\n";
                 cin >> tempo;
                 system("cls");
                 cout << "\nDigite velocidade média durante a viagem:\n";
                 cin >> velocidade;
                 system("cls");
                 distancia = tempo * velocidade; 
                 litros = distancia/12;
                 cout << "\nVelociade média = " << velocidade << " km/h\
                          \nTempo gasto na viagem = " << tempo << " h\
                          \nDistância percorrida = " << distancia << " km\
                          \nQuantidade de litros utilizados = " << litros << " por km\n\n";
                 system("pause");
                 }
    }
}
