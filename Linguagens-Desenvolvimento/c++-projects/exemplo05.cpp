#include "iostream"
#include "cstdlib"
#include "math.h"
#include "conio.h"
#include "windows.h"
using namespace std;
    
        string cae="";
    struct pes{
           int ida, CPF, RG;
           double sal;
           string nom, end, ba, cid, est, dn;
           };
           
    struct pes p1[10];
           void armazenar(int newlin, string nome, int cpf, int rg, string ende, string bai,string cida, string esta, double sa, int id, string ddn){
                string a="";
                         
                for(int i =0; i< newlin; i++){
                        if((p1[i].ida == 0) && (p1[i].sal == 0) && (p1[i].CPF == 0) && (p1[i].RG == 0)){
                            if(i>0){
                              a="zero";  
                            }
                        }
                    }
                    if(a=="zero"){
                        p1[newlin-1].nom = nome;
                        p1[newlin-1].CPF = cpf;
                        p1[newlin-1].RG = rg;
                        p1[newlin-1].end = ende;
                        p1[newlin-1].ba = bai;
                        p1[newlin-1].cid = cida;
                        p1[newlin-1].est = esta;
                        p1[newlin-1].sal = sa;
                        p1[newlin-1].ida = id;
                        p1[newlin-1].dn = ddn;
                    }else{
                        p1[newlin].nom = nome;
                        p1[newlin].CPF = cpf;
                        p1[newlin].RG = rg;
                        p1[newlin].end = ende;
                        p1[newlin].ba = bai;
                        p1[newlin].cid = cida;
                        p1[newlin].est = esta;
                        p1[newlin].sal = sa;
                        p1[newlin].ida = id;
                        p1[newlin].dn = ddn;
                    }
           
           }void excluir(int pos, int lastline, char opcao){
                 char op = opcao;
                 int linha = lastline;
                  if ((op=='s') || (op=='S')){
                                for(int i=pos; i<= lastline; i++){
                                        p1[i] = p1[i+1];
                                }
                                cout<<"\nAção concluida com sucesso!\n"<<endl;  
                  }else if((op=='n') || (op=='N')){
                             // volta para o menu    
                  }else{
                             cout<<"\nOpção invalida.";
                             Sleep(3000);
                           
                  }
                  
                 
            }void alterar(int lastline){
                 string nome, endereco;
                                cout<<"\nDigite Nome:";
                                cin >> nome;
                                cout<<"\nDigite Endereço:";
                                cin >> endereco;
                        p1[lastline].nom = nome;
                        p1[lastline].end = endereco;
                        cout<<"\nAção concluida com sucesso!\n"<<endl;  
                 
            }void consultar(int lastline){
                 int pos=-1, cpf=-0;
                 char op;
                 system("cls");
                 cout<<"\nDigite CPF que desejar procurar:";                 
                 cin >> cpf;
                 
                 for(int i =0; i<= lastline; i++){
                 if (cpf== p1[i].CPF){
                           pos = i;
                          }
                           }
                           
                           if((pos>=0) && (pos<=lastline)){
                           cout<<"Código | Nome | CPF | RG | Endereço | Bairro | Cidade | Estado | Salário | Idade | Data de Nascimento:"<<endl;
                           cout<< p1[pos].nom << " | " << p1[pos].CPF << " | " << p1[pos].RG << " | " << p1[pos].end << " | " 
                               << p1[pos].ba<< " | " << p1[pos].cid << " | " << p1[pos].est << " | " << p1[pos].sal << " | " 
                               << p1[pos].ida << " | " << p1[pos].dn <<"\n" ;
                 if(cae=="excluir"){
                           cout<< "\nDeseja Excluir registro do CPF: " << cpf << ", realmente? S- Sim, N- Não\n";
                           cin >>op;
                           excluir(pos, lastline,op);
                 }else if(cae=="alterar"){
                           cout<< "\nDeseja Alterar registro do CPF: " << cpf << ", realmente? S- Sim, N- Não\n";
                           cin >>op;
                           alterar(pos); 
                 }
                 
                 }else{
                 cout<<"\CPF incorreto.";
                 Sleep(1000);
                 consultar(lastline);
                 }
                 
                system("pause"); 
                 
            }void exibir(int lastline){
                system("cls");
                cout<<"Código | Nome | CPF | RG | Endereço | Bairro | Cidade | Estado | Salário | Idade | Data de Nascimento:";
                for(int i =0; i<= lastline; i++){
                        if(((p1[i].ida != 0) && (p1[i].sal != 0) &&p1[i].CPF != 0) && (p1[i].RG != 0)){
                        cout<<"\n" << i+1 <<"º | " << p1[i].nom << " | " << p1[i].CPF << " | " << p1[i].RG << " | " 
                        << p1[i].end << " | " << p1[i].ba<< " | " << p1[i].cid << " | " << p1[i].est << " | " 
                        << p1[i].sal << " | " << p1[i].ida << " | " << p1[i].dn << endl;
                        }
                        }                       
            system("pause");
            }
int tela(){
    int tecla;
    system("cls");
    cout<<"**TELA DE CADASTRO**\n";
    cout<< "\n1 - Inserir";
    cout<< "\n2 - Consultar por CPF";
    cout<< "\n3 - Excluir por CPF";
    cout<< "\n4 - Alterar por CPF";
    cout<< "\n5 - Exibir";
    cout<< "\n6 - Sair";
    cout<< "\nItem> ";
    cin >> tecla;            
 return tecla;
}

void controleMenu(){
     int tecla = -1, linha =-1, idade=0, rg=0;
     float cpf =0;
     double salario;
     string nome, endereco, bairro, cidade, estado, data_nasc;
     while(tecla!=6){
                     tecla= tela();
                     switch (tecla){
                           case 1:{
                                cin.ignore();
                                system("cls");
                                cout<<"\nDigite Nome:";
                                getline(cin,nome);
                                cout<<"\nDigite CPF(apenas números):";
                                cin >> cpf;
                                cout<<"\nDigite RG:(apenas números):";
                                cin >> rg;
                                cout<<"\nDigite Endereço:";
                                cin.ignore();
                                getline(cin,endereco);
                                cout<<"\nDigite Bairro:";
                                cin >> bairro;
                                cout<<"\nDigite Cidade:";
                                cin >> cidade;
                                cout<<"\nDigite Estado(sigla):";
                                cin >> estado;
                                cout<<"\nDigite Salário:";
                                cin >> salario;
                                cout<<"\nDigite Idade:";
                                cin >> idade;
                                cout<<"\nDigite Data de Nascimento:";
                                cin >> data_nasc;
                                linha++;
                                armazenar(linha,nome,cpf,rg,endereco,bairro,cidade,estado,salario,idade,data_nasc);
                                break;
                           }case 2:{
                                cae="consultar";
                                consultar(linha);
                                break;
                           }case 3:{
                                cae="excluir";
                                consultar(linha);
                                break;
                           }case 4:{
                                cae="alterar";
                                consultar(linha);
                                break;
                           }case 5:{
                                exibir(linha);
                                break;                                 
                           }case 6:{
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
