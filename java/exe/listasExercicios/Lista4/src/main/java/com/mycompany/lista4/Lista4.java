/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.lista4;

import javax.swing.JOptionPane;

public class Lista4 {

   public static void main(String[] args) {
        menu();
    }
        // CRIAÇÃO DE MENU PARA SELECIONAR QUAL EXECÍRCIO DESEJA EXECUTAR
        static void menu(){
            try{
                int exe;
                do{
                String a = JOptionPane.showInputDialog(null,"Digite o número exercício a ser executado(1 à 8)\n"
                        + "para sair digite '0':");
                exe = Integer.parseInt(a);
                if(exe<0){
                    throw new Exception ("Intervalo");
                }else if(exe>8){
                    throw new Exception ("Intervalo");
                }
                    switch (exe) {
                        case 1 -> ex1();
                        case 2 -> ex2();
                        case 3 -> ex3();
                        case 4 -> ex4();
                        case 5 -> ex5();
                        case 6 -> ex6();
                        case 7 -> ex7();
                        case 8 -> ex8();
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
                JOptionPane.showMessageDialog(null, "Não digite números menores que 0 ou maiores que 8!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                menu();
            }
        }
        
        //1ª) Criar um programa que permita a entrada de um número inteiro e retorne o seu dobro, através de um método. 
        static void ex1(){
            try{
             String t = JOptionPane.showInputDialog(null,"Digite valor: ");
             JOptionPane.showMessageDialog(null,"Dobro de "+t+" = "+dobro(Integer.parseInt(t)),"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }catch (NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Digite apenas números inteiros!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex1();
            }
}
        static int dobro(int a){
            int b = a * 2;
            return b;
            }

        //2ª) Criar um programa que receba 4 notas e calcule a média aritmética, através de um método.
        static void ex2(){
            try{
            int posicao = 1;
            float a=0,b=0,c=0,d=0;
            do {
            String t = JOptionPane.showInputDialog(null,"Digite "+posicao+"ª nota: ");
            float x = Float.parseFloat(t);
                if(x<0){
                    throw new Exception ("maior10");
                }else if(x>10){
                    throw new Exception ("maior10");
                }
                switch (posicao) {
                    case 1 -> a= x;
                    case 2 -> b= x;
                    case 3 -> c= x;
                    case 4 -> d= x;
                }
                posicao+=1;
            }while (posicao <=4);
            
            JOptionPane.showMessageDialog(null,"a média das notas é: " +media(a,b,c,d),"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }catch (NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Digite apenas números reias!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex2();
            }catch (Exception maior10){
                JOptionPane.showMessageDialog(null, "Não digite números menores que 0 ou maiores que 10!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex2();
            }
        }
        static float media(float a, float b, float c, float d){
            float m = (a+b+c+d)/4;
            return m;
            }
        
        //3ª) Criar um programa que receba 2 valores e calcule o produto através de um método que retorna valores. 
        static void ex3(){
            try{
                String t = JOptionPane.showInputDialog(null,"Digite 1ª valor: ");
                float a = Float.parseFloat(t);
                t = JOptionPane.showInputDialog(null,"Digite 2ª valor: ");
                float b = Float.parseFloat(t);
                JOptionPane.showMessageDialog(null,a+" X "+b+" = "+mult(a,b) ,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }catch (NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Digite apenas números reias!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex3();
            }
        }
        static float mult(float a,float b){
            float mult = a*b;
            return mult;
            }
        
        /**4ª) Criar um programa que receba um grau e o converta para radianos através de um método. 
                Fórmula: radiano = grau * pi / 180 **/
        static void ex4(){
            try{
                String t = JOptionPane.showInputDialog(null,"Digite grau: ");
                JOptionPane.showMessageDialog(null,"Radiano: "+grau(Double.parseDouble(t)) ,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }catch (NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Digite apenas números reias!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex4();
            }
        }
        static double grau(double a){
            double b = a*3.1415 /180;
            return b;
            }

        //5ª) Criar um programa que mostre qual o maior valor entre dois números, utilizando um método do tipo void (que não retorna valores). 
        static void ex5(){
            try{
                String t = JOptionPane.showInputDialog(null,"Digite 1ª valor: ");
                int a = Integer.parseInt(t);
                t = JOptionPane.showInputDialog(null,"Digite 2ª valor: ");
                int b = Integer.parseInt(t);
                maior(a,b);
            }catch (NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Digite apenas números inteiros","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex5();
            }
        }
        static void maior(int a, int b){
            if (a > b){
            JOptionPane.showMessageDialog(null,a+" > "+b ,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }else if (a < b){
            JOptionPane.showMessageDialog(null,b+" > "+a ,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }else{
            JOptionPane.showMessageDialog(null,"Valores iguais ("+a+")","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }
        }
        
        /**6ª) Criar um programa que receba um número que corresponda a um mês do 1º trimestre e escreva o mês correspondente; caso o usuário 
               digite o número fora do intervalo deverá aparecer inválido, mas utilizando um método do tipo void. **/
        static void ex6(){
                try{
                    String t = JOptionPane.showInputDialog(null,"Digite número do 1º mês trimestre do ano: ");
                    mes(Integer.parseInt(t));
                }catch (NumberFormatException e){
                    JOptionPane.showMessageDialog(null, "Digite apenas números inteiros","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                    ex6();
                }
        }
        static void mes(int a){
            if (a == 1){
                JOptionPane.showMessageDialog(null,a+" = o mês de janeiro.","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }else if (a ==2){
                JOptionPane.showMessageDialog(null,a+" = o mês de feveiro.","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }else if (a ==3){
                JOptionPane.showMessageDialog(null,a+" = o mês de março." ,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }else{
                JOptionPane.showMessageDialog(null,"número digitado fora do intervalo","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
            }
        }

        /**7ª) Criar um programa que retorne o fatorial de um número, usando um método que receba um valor e retorne o fatorial desse valor. 
               Fatorial de 5 = 5 x 4 x 3 x 2 x 1 = 120 **/
        static void ex7(){
            try{
                String t = JOptionPane.showInputDialog(null,"Digite valor: ");
                int a = Integer.parseInt(t);
                    if (a > 0){
                        vetor(a);
                    }else{
                        JOptionPane.showMessageDialog(null,"Digite apenas número maior que 0","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                    }
            }catch (NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Digite apenas números inteiros","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex7();
            }
        } 
        static void vetor(int a){
            int cont=1;
            int fatoral = 1;
            String mostrar=a+"";
            for(int i = a-1; i > 0; --i){
                cont=i+1;
                fatoral = fatoral*cont;
                mostrar+=" X "+i;
            }
            JOptionPane.showMessageDialog(null,"fatorial de "+a+" ("+mostrar+") = "+fatoral,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }
        
        //8ª) Criar um programa que verifique se um número é primo ou não, através de um método. Número primo é divisível somente por 1 e por ele mesmo.
        static void ex8(){
            try{
                String t = JOptionPane.showInputDialog(null,"Digite número: ");
                int a = Integer.parseInt(t);
                if (primo(a)){
                    JOptionPane.showMessageDialog(null,a+" É um número primo","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
                }else{
                    JOptionPane.showMessageDialog(null,a+" NÃO É um número primo","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
                }
            }catch (NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Digite apenas números inteiros","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex8();
            }
        }
        static boolean primo(int a) {
            for (int j = 2; j < a; j++) {
                if (a % j == 0)
                    return false;   
            }
            return true;
        }

}

