
package com.mycompany.lista7;

import javax.swing.JOptionPane;


public class Lista7 {

    public static void main(String[] args) {
        executar();
    }
    /*
Criar uma classe para curso Superior contendo os seguintes atributos privativos à
classe: N1, N2, N3. Deverá conter também o método público CalculaMedia().
Herdar da classe Superior os atributos e método gerando a subclasse Tecnico.
Na classe Superior:
N1 = Nota da P1;
N2 = Nota da P2;
N3 = Nota de trabalhos.
Média = (N1*0,35 + N2*0,5 + N3*0,15)
Na classe Tecnico:
N1 = Nota do 1º Trimestre;
N2 = Nota do 2º Trimestre;
N3 = Nota do 3º Trimestre;.
Média = (N1 + N2*2 + N3*2)/5;
Criar uma classe principal, instanciar um objeto a partir da classe Superior e outro
objeto a partir da classe Tecnico.
Solicitar as notas e exibir as médias.
 */
    private static void executar(){
        try{
            double n1=0,n2=0,n3=0,media=0;
            int posicao=1;
            do {
            String texto = JOptionPane.showInputDialog(null,"Digite "+posicao+"ª nota: ");
            double temp = Double.parseDouble(texto);
                if(temp<0){
                    throw new Exception ("intervalo");
                }else if(temp>10){
                    throw new Exception ("intervalo");
                }
                switch (posicao) {
                    case 1 -> n1= temp;
                    case 2 -> n2= temp;
                    case 3 -> n3= temp;
                }
                posicao+=1;
            }while (posicao <=3);
            
            Superior Superior = new Superior(n1,n2,n3);
            Tecnico Tecnico = new Tecnico(n1,n2,n3);
            JOptionPane.showMessageDialog(null,"N1 = "+n1+"\nN2 = "+n2+"\nN3 = "+n3+"\n"
                    + "Média do Curso Superior: "+ Superior.CalculaMedia(true)+"\n"
                    + "Cálculo = ("+n1+"*0,35 + "+n2+"*0,5 + "+n3+"*0,15) = " + Superior.CalculaMedia(true)+"\n\n"
                    + "Média do Curso Técnico é: "+ Tecnico.CalculaMedia(false)+"\n"
                    + "Cálculo = ("+n1+" + "+n2+"*2 + "+n3+"*2)/5 = " + Tecnico.CalculaMedia(false));
            
            }catch (NumberFormatException ex){
                JOptionPane.showMessageDialog(null, "Digite apenas números!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                executar();
            }catch (Exception intervalo){
                JOptionPane.showMessageDialog(null, "Não digite números menores que 0 ou maiores que 10!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                executar();
            }
    }
}
