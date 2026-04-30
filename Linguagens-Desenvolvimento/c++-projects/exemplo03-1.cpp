#include "iostream" // cin cout
#include "cstdlib" // system
#include "conio.h" // getch() getche()
#include "windows.h" // Sleep(1000)
#include "math.h" //
#include "locale.h"
#define pi 3.14"
using namespace std;
//float const pi = 3.14;
int main() {
// Configurando idioma
setlocale(LC_ALL, "Portuguese");
float ar, dia, rai, cp;
system("cls");
cout << "\n** Programa Círculo ** ";
cout <<"\n\n\nDigite o comprimento:";
cin >> cp;
dia = cp / pi; // comprimento
cout << "\ncalculando diâmetro...";
Sleep(1000);
rai = dia / 2; // raio
cout << "\ncalculando raio...";
Sleep(1000);
ar = pow(rai, 2 ) * pi; // área
cout << "\ncalculando a área...";
Sleep(1000);
cout<< "\n\n\n\***Mostrando Resultados***";
cout << "\nComprimento:" << cp;
cout << "\nDiâmetro...:" << dia;
cout << "\nRaio.......:" << rai;
cout << "\nÀrea.......:" << ar << endl;
system("pause");
return 0;
}
