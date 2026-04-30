#include <iostream>
#include <math.h>
#include <cstdlib>

#include "locale.h"
 using namespace std;
       
       struct pes {
              string nome;
              double sal;
              char sexo; 
              };
       struct pes tabela[10];
       
void armazenar(int newlin, string no, double sa, char se){
                tabela[newlin].nome = no;
                tabela[newlin].sal = sa;
                tabela[newlin].sexo = se;
                }
                
                void exibir(int lastline){
                system("cls");
                string sex="";
                for(int i =0; i<= lastline; i++){
                        if((tabela[i].sexo == 'f') || (tabela[i].sexo == 'F')){
                            sex = "Feminino";    
                           }else if((tabela[i].sexo == 'm') || (tabela[i].sexo == 'M')){
                            sex = "Masculino";                                
                           }
                        cout<<"\n" << tabela[i].nome << " - " << tabela[i].sal << " sexo: " << sex << "\n";
                        }
                system("pause");
                }
                
                void processar(int lastline){
                double somafem =0, somamas =0;
                int contfem=0, contmas=0;
                for(int i =0; i<= lastline; i++){
                           if((tabela[i].sexo == 'f') || (tabela[i].sexo == 'F')){
                                somafem += tabela[i].sal;//acumular
                                contfem++;//contar
                           }else if((tabela[i].sexo == 'm') || (tabela[i].sexo == 'M')){
                                somamas += tabela[i].sal;//acumular
                                contmas++;//contar
                           }
                 }
                                system("cls");
                                cout<<"\nmédia dos salário das mulheres: " << somafem/contfem<< endl;
                                cout<<"\nmédia dos salários dos homens: " << somamas/contmas<< endl;
                                cout<<"\nmédia total dos salários: " << (somafem+somamas)/(contfem+contmas)<< "\n";
                                system("pause");
            }
            
int tela(){
    int tecla;
    system("cls");
    cout<<"**TELA INICIAL**\n";
    cout<< "\n1 - Ler";
    cout<< "\n2 - Processar";
    cout<< "\n3 - Exibir";
    cout<< "\n4 - Sair";
    cout<< "\nItem> ";
    cin >> tecla;            
 return tecla;
}

void controleMenu(){
     int tecla = -1, linha =-1;
     string nom="";
     char sex;
     double salario;
     while(tecla!=4){
                     tecla= tela();
                     switch (tecla){
                           case 1:{
                                system("cls");
                                cout<<"\nDigite Nome:";
                                cin >> nom;
                                cout<<"\nDigite Salário:";
                                cin >> salario;
                                cout<<"\nDigite Sexo: F-Feminino, M- Masculino:\n";
                                cin >> sex;
                                if((sex=='f') || (sex=='F') || (sex=='m') || (sex=='M')){
                                linha++;
                                armazenar(linha,nom,salario,sex);
                                }else{
                                cout<<"\nSexo digitado incorretamente, digite comandos novamente.";
                                controleMenu();
                                      }
                                break;
                           }case 2:{
                                processar(linha);
                                break;
                                }case 3:{
                                exibir(linha);
                                break;
                                }
                           }
             }
     }
int main(){
    setlocale(LC_ALL, "Portuguese");
    controleMenu();
    return 0;
}
