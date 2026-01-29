

package com.mycompany.lista5;
import javax.swing.JOptionPane;


public class Lista5 {

    public static void main(String[] args) {
       menu();
    }
 
// CRIAÇÃO DE MENU PARA SELECIONAR QUAL EXECÍRCIO DESEJA EXECUTAR
    private static void menu(){
            try{
                int exe;
                do{
                String a = JOptionPane.showInputDialog(null,"Digite o número exercício a ser executado(1 à 3)\n"
                        + "para sair digite '0':");
                exe = Integer.parseInt(a);
                if(exe<0){
                    throw new Exception ("Intervalo");
                }else if(exe>3){
                    throw new Exception ("Intervalo");
                }
                    switch (exe) {
                        case 1 -> exe01();
                        case 2 -> exe02();
                        case 3 -> exe03();
                        default -> {
                            JOptionPane.showMessageDialog(null, "Até Mais!!","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
                            exe = 0;
                        }
                    }
                
            }while (exe != 0);
            }catch (NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Digite apenas números inteiros!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                menu();
            }catch (Exception Intervalo){
                JOptionPane.showMessageDialog(null, "Não digite números menores que 0 ou maiores que 3!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                menu();
            }
        }  

    
/*
1ª) Criar uma Classe chamada Triangulo que contenha como atributos a base e altura de um
triângulo. Na classe definir um método para leitura da base e altura, um método construtor e
um método para Calcular a área do triângulo (Area=Base * Altura)/2.
No método principal do programa (main) , criar um objeto a partir da classe criada, solicitar
e atribuir os valores da base e altura e invocar o método que calcula a área a partir do objeto
criado. 
*/
    private static void exe01(){
        try{
            double n1,n2;
            String v1;
            v1 = JOptionPane.showInputDialog("Base triangulo: ");
            n1 = Double.parseDouble(v1);
            v1 = JOptionPane.showInputDialog("Altura triangulo: ");
            n2 = Double.parseDouble(v1);
            if(n1<=0 || n2<=0){
                throw new Exception("Invalido");
            }
            Triangulo triangulo = new Triangulo();
            triangulo.SetTriangulo(n1, n2);
            JOptionPane.showMessageDialog(null,"A area do triangulo é:\n " + triangulo.GetArea());
            }catch (NumberFormatException ex){
                JOptionPane.showMessageDialog(null, "Digite apenas números!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
            }catch (Exception Invalido){
                JOptionPane.showMessageDialog(null, "Digite apenas números positivos diferentes de 0!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
            }
 
 }
 
    
/*
 2ª) Criar uma Classe chamada Equacao que contenha como atributos 3 valores inteiros, A, B
e C. Na classe definir um método para leitura dos valores, um método construtor e um método
para calcular as raízes da equação.
R1 = (-b+ (raiz de delta)) / (2*a)
R2 = (-b-(raiz de delta)) / (2*a)
Considerar que:
- Se delta = 0, as raízes são iguais;
- Se delta <0, não existem raízes reais;
- Se delta >0, existem 2 raízes diferentes
No método principal do programa (main) , criar um objeto a partir da classe criada, solicitar
e atribuir os valores e invocar o método que calcula as raízes a partir do objeto criado.
 */
     private static void exe02(){
        try{
            int n1,n2, n3;
            String v1;
            v1 = JOptionPane.showInputDialog("Valor A da equação: ");
            n1 = Integer.parseInt(v1);
            v1 = JOptionPane.showInputDialog("Valor B da equação: ");
            n2 = Integer.parseInt(v1);
            v1 = JOptionPane.showInputDialog("Valor C da equação: ");
            n3 = Integer.parseInt(v1);
            Equacao equacao = new Equacao();
            equacao.SetValores(n1, n2, n3);
            equacao.GetDelta();
            equacao.GetR1();
            equacao.GetR2();
            equacao.Raizes();
            }catch (NumberFormatException ex){
                JOptionPane.showMessageDialog(null, "Digite apenas números inteiros!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
            }
    }
 
     
/*
3ª) Criar uma classe Pessoa com as seguintes características:
• atributos: idade e dia, mês e ano de nascimento, nome da pessoa

• métodos:
o calculaIdade(), que recebe a data atual em dias, mês e anos e calcula e
armazena no atributo idade a idade atual da pessoa;
o informaIdade(), que retorna o valor da idade
o informaNome(), que retorna o nome da pessoa
o ajustaDataDeNascimento(), que recebe dia, mês e ano de nascimento como
parâmetros e preenche nos atributos correspondentes do objeto.

• Criar dois objetos da classe Pessoa, um representando Albert Einstein (nascido em
14/03/1879) e o outro representando Isaac Newton (nascido em 04/01/1643)
•Fazer uma classe principal que instancie os objetos, inicialize e mostre quais seriam
as idades de Einstein e Newton caso estivessem vivos
 */
     private static void exe03(){
         Pessoa Einstein = new Pessoa();
         Einstein.inserirNome("Albert Einstein");
         Einstein.ajustaDataDeNascimento(14,3,1879);
         Einstein.calculaIdade();
         Pessoa Newton = new Pessoa();
         Newton.inserirNome("Isaac Newton");
         Newton.ajustaDataDeNascimento(4,1,1643);
         Newton.calculaIdade();
         JOptionPane.showMessageDialog(null,Einstein.informaNome()+" teria "+Einstein.informaIdade()+" anos se estivesse vivo!\n"
                 +Newton.informaNome()+" teria "+Newton.informaIdade()+" anos se estivesse vivo!");
     }
}

  

