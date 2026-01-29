/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.lista03;

import java.util.ArrayList;
import java.util.List;
import javax.swing.JOptionPane;
public class Lista03 {

    public static void main(String[] args) {
        menu();
    }
        // CRIAÇÃO DE MENU PARA SELECIONAR QUAL EXECÍRCIO DESEJA EXECUTAR
        static void menu(){
            try{
                int exe;
                do{
                String a = JOptionPane.showInputDialog(null,"Digite o número exercício a ser executado(1 à 5)\n"
                        + "para sair digite '0':");
                exe = Integer.parseInt(a);
                if(exe<0){
                    throw new Exception ("Intervalo");
                }else if(exe>5){
                    throw new Exception ("Intervalo");
                }
                switch (exe) {
                    case 1 -> ex1();
                    case 2 -> ex2();
                    case 3 -> ex3();
                    case 4 -> ex4();
                    case 5 -> ex5();
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
                JOptionPane.showMessageDialog(null, "Não digite números menores que 0 ou maiores que 5!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                menu();
            }
        }
    
    
        // 1) Um programa capaz de imprimir todos os números pares em um intervalo de números informador pelo usuário;
        static void ex1(){
            String a,mo="";
                int maior=0, menor=0; 
            try{
                a = JOptionPane.showInputDialog(null,"Digite valor incial de intervalo: ");
                menor = Integer.parseInt(a);
                a = JOptionPane.showInputDialog(null,"Digite valor final de intervalo: ");
                maior = Integer.parseInt(a);
                if(menor>maior){
                    throw new Exception ("Exc");
                }
                for(int i=menor; i<=maior; i++){
                    if(i % 2 == 0){
                    mo = mo +" "+i;
                    }
                }
                JOptionPane.showMessageDialog(null, "Números pares de "+menor+" até "+maior+":\n"+mo,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }catch (NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Digite apenas números inteiros!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex1();
            }catch (Exception Exc){
                JOptionPane.showMessageDialog(null, "O número inicial não pode ser maior que o número final!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex1();
            }
        }
        
        /** 2) Um programa que imprima até o “n” termo a seqüência de Fibonacci. Série: 1,1,2,3,5,8,13,21....... 
                Por exemplo, imprimir até o 6º termo: 1, 1, 2, 3, 5, 8   **/
        static void ex2(){
            int num1 =1, num2=0, intervalo;
            String a,mo =""+num1;
            try{
               a = JOptionPane.showInputDialog(null,"Digite o termo: ");
               intervalo = Integer.parseInt(a);
               if(intervalo<=0){
                   throw new Exception ("MenorIgualZero");
               }
                for(int i = 1; i < intervalo; i++){
                    num1 = num1 + num2;
                    num2 = num1 - num2;
                    mo = mo +" "+num1;
               }
               JOptionPane.showMessageDialog(null, "Sequência de Fibonacci até o "+intervalo+"º termo:\n"+mo,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }catch (NumberFormatException e){
               JOptionPane.showMessageDialog(null, "Digite apenas números inteiros!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
               ex2();
            }catch (Exception MenorIgualZero){
               JOptionPane.showMessageDialog(null, "Não digite números menores que 0!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
               ex2();
            }
        }
        
        // 3) Um programa capaz de imprimir todos os números primos em um intervalo de números informado pelo usuário
        static void ex3(){
            int intervalo=0;        
                String a,mo="";
            try{
                a = JOptionPane.showInputDialog(null,"Digite intervalo de números: ");
                intervalo = Integer.parseInt(a);
                    if(intervalo<=0){
                    throw new Exception ("MenorIgualZero");
                    }
                List<Integer> numeros = new ArrayList<Integer>();

                for(int i = 0; i <= intervalo; i++){
                numeros.add(i);
                }
                    int contador;   
                    int numero = 0;
                    for (Integer i : numeros) {
                    contador = 0;

                    for (int u = 1; u <= i; u++) {
                        if (i % u == 0){
                        contador++;
                        numero = u;
                        }
                    }
                        if (contador == 2){
                        mo= mo+" "+numero; 
                        }
                    }
                JOptionPane.showMessageDialog(null, "todos os números primos até no maximo "+intervalo+":\n"+mo,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
            }catch (NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Digite apenas números inteiros!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex3();
            }catch (Exception MenorIgualZero){
                JOptionPane.showMessageDialog(null, "Digite números maiores que 0!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex3();}
        }

        //4) Um programa que calcule a média de uma aluno nos moldes da Fatec Zona SUL.
        static void ex4(){
            float media=0, p1=0, p2=0, ativ=0;        
            String temp ="Atividade";

            try{
            for(int i=0; i<=2; i++){
                float num=0;
                String a = JOptionPane.showInputDialog(null,"Digite a nota do aluno na "+temp);
                num = Float.parseFloat(a);
                if(num<0){
                throw new Exception ("errado");
                }else if(num>10){
                throw new Exception ("errado");
                }
                 if (i == 0){
                    ativ=num;
                    temp = "P1";
                }else if (i == 1){
                    p1=num;
                    temp = "P2";
                }else{
                    p2=num;
                    media =  (float) (p1*0.35 + p2*0.50 + ativ*0.15);
                }
            }
                if (media >=6){
                JOptionPane.showMessageDialog(null, "APROVADO!! \nMédia do aluno é: \n"+media,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
                }else{
                JOptionPane.showMessageDialog(null, "REPROVADO!! \nMédia do aluno é: \n"+media,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
                    }
            }catch (NumberFormatException ex){
                JOptionPane.showMessageDialog(null, "Digite apenas números!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex4();
            }catch (Exception errado){
                JOptionPane.showMessageDialog(null, "As notas são apenas dadas de 0 até 10","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex4();
            }
        }

        /**  5) Criar um programa que leia um número que será o limite superior de um intervalo e o incremento. Exibir todos os números 
             naturais no intervalo de 0 até esse número. Suponha que os dois números lidos são maiores que zero. Exemplo:
             Limite superior: 20
             Incremento: 5
             Saída: 0 5 10 15 20     **/
        static void ex5(){
            String a,mo="";
                int lim=0, inter =0; 
            try{
                a = JOptionPane.showInputDialog(null,"Digite limite de números: ");
                lim = Integer.parseInt(a);
                if(lim<0){
                throw new Exception ("MenorIgualZero");
                }
                a = JOptionPane.showInputDialog(null,"Digite intervalo dos números: ");
                inter = Integer.parseInt(a);
                if(inter<0){
                throw new Exception ("MenorIgualZero");
                }
                if(inter>lim){
                JOptionPane.showMessageDialog(null, "Intervalo maior que limite","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex5();
                }else{
                for(int i=1; i<=lim; i++){
                    if(i % inter == 0){
                    mo = mo +" "+i;
                    }
                }
                JOptionPane.showMessageDialog(null, "0 "+mo,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
                }
            }catch (NumberFormatException e){
                JOptionPane.showMessageDialog(null, "Digite apenas números inteiros!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex5();
            }catch (Exception MenorIgualZero){
                JOptionPane.showMessageDialog(null, "Digite números maiores ou igual a 0!","MENSSAGEM", JOptionPane.ERROR_MESSAGE);
                ex5();
            }
        }

}
