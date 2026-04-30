#include "iostream"
#include "cstdlib"
#include "math.h"
#include "conio.h"

using namespace std;

    struct pes{
           int ida;
           double sal;
           };
           
    struct pes p1[10];
           void armazenar(int newlin, int id, double sa){
                string a="";
                         
                for(int i =0; i< newlin; i++){
                        if((p1[i].ida == 0) && (p1[i].sal == 0)){
                            if(i>0){
                              a="zero";  
                            }
                        }
                    }
                    if(a=="zero"){
                        p1[newlin-1].ida = id;
                        p1[newlin-1].sal = sa;
                    }else{
                        p1[newlin].ida = id;
                        p1[newlin].sal = sa;
                    }
          
          }void exibir(int lastline){
                system("cls");
                cout<<"Código | Idade | Salário\n";
                for(int i =0; i<= lastline; i++){
                        if((p1[i].ida != 0) && (p1[i].sal != 0)){
                        cout<<"\n" << i+1 <<"º " << p1[i].ida << " | " << p1[i].sal << endl;
                        }
                        }
                system("pause");                        
           
           }void processar(int lastline){
            double soma =0;
            int contmaior =0;
            
            for(int i =0; i<= lastline; i++){
                if((p1[i].ida != 0) && (p1[i].sal != 0) && (p1[i].ida >= 18)){                    
                    soma += p1[i].sal;//acumular
                    contmaior++;//contar
                    }
            }
            system("cls");
            cout<<"\nMédia dos Sálarios...:" << soma/contmaior<< endl;
            cout<<"\nQuantidade de maiores:" << contmaior<< endl;
            system("pause");
            
            
            }void excluir(int pos, int lastline){
                 for(int i=(pos-1); i<= lastline; i++){
                         p1[i] = p1[i+1];
                         }
            }void consultar(int lastline){
                 int pos=-1;
                 char op;
                 system("cls");
                 cout<<"\n*****PESQUISA AVANÇADA*****";
                 cout<<"\nDigite posição que desejar procurar de 1 á "<< lastline+1 <<" ou 0 para todos: ";                 
                 cin >> pos;
                 if((pos>=1) && ((pos-1)<=lastline)){
                 cout<< p1[pos-1].ida << " - " << p1[pos-1].sal <<"\n" ;
                 cout<< "\nDeseja excluir registro " << pos << "? S- Sim, N- Não\n";
                 cin >>op;
                     if ((op=='s') || (op=='S')){
                     excluir(pos, lastline);         
                     }else if((op=='n') || (op=='N')){
                      //não faz nada
                     }else{
                     cout<<"\nOpção invalida.";
                      consultar(lastline);
                     }
                 }else if(pos==0){
                 cout<<"Código | Idade | Salário\n";
                 for(int i =0; i<= lastline; i++){
                         if((p1[i].ida != 0) && (p1[i].sal != 0)){ 
                         cout<<"\n" << i+1 <<"º " << p1[i].ida << " | " << p1[i].sal << "\n";
                         }
                        }
                 system("pause");
                 consultar(lastline);
                 }else{
                 cout<<"\nPosição incorreta.";
                 consultar(lastline);
                 }
                 
            
 }int tela(){
    int tecla;
    system("cls");
    cout<<"**TELA INICIAL**\n";
    cout<< "\n1 - Ler";
    cout<< "\n2 - Processar";
    cout<< "\n3 - Exibir";
    cout<< "\n4 - Pesquisa Avançada";
    cout<< "\n5 - Sair";
    cout<< "\nItem> ";
    cin >> tecla;            
 return tecla;
        }void controleMenu(){
        int tecla = -1, linha =-1, idade=0;
        double salario;
        while(tecla!=5){
                     tecla= tela();
                     switch (tecla){
                           case 1:{
                                system("cls");
                                cout<<"\nDigite Idade:";
                                cin >> idade;
                                cout<<"\nDigite Salário:";
                                cin >> salario;
                                linha++;
                                armazenar(linha,idade,salario);
                                break;
                           }case 2:{
                                processar(linha);
                                break;
                           }case 3:{
                                exibir(linha);
                                break;
                           }case 4:{
                                 consultar(linha);
                                break;                                 
                           }case 5:{
                                  exit(0);
                                break;                                 
                           }default: 
                                 cout<<"\nValor digitado incorretamente, digite comandos novamente.";
                                 break;
                           }
             }
     }
int main(){
    setlocale(LC_ALL, "Portuguese");
    controleMenu();
    return 0;
}
