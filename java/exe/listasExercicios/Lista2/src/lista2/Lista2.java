
package lista2;

import java.util.Arrays;
import javax.swing.JOptionPane;

public class Lista2 {

    public static void main(String[] args) {
        int exe;
        do{ 
        String a = JOptionPane.showInputDialog(null,"Digite o número exercicio a ser executado(1 à 5)\n"
                + "para sair digite qualquer outro número:");
        exe = Integer.parseInt(a);
        
        switch (exe) {
            case 1:
                exercicio1();
                break;
            case 2:
                exercicio2();
                break;
            case 3:
                exercicio3();
                break;
            case 4:
                exercicio4();
                break;
            case 5:
                exercicio5();
                break;
            default:
                exe = 0;
                break;
        }
    }while (exe != 0); 
    
    }
        
        static void exercicio1(){
        String a = JOptionPane.showInputDialog(null,"Digite valor: ");
        int val = Integer.parseInt(a);
        if(val % 3 == 0){
        JOptionPane.showMessageDialog(null, "Número "+ val +" É multiplo por 3","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
        }else{
        JOptionPane.showMessageDialog(null, "Número "+ val +" NÃO É multiplo por 3","MENSSAGEM" ,JOptionPane.ERROR_MESSAGE);
        }
        }
        
        static void exercicio2(){
         int val[] = new int[3];
        String m= "";
        for (int i=0; i<=2;i++){
        String a = JOptionPane.showInputDialog(null,"Digite "+(i+1) +"º valor: ");
        val[i]= Integer.parseInt(a);
        }Arrays.sort(val);
        for (int i=0; i<=2;i++){
        m= m+val[i]+"\n";
        }JOptionPane.showMessageDialog(null, "Ordem crescente dos números digitados:\n"+ m,"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
        }
        
        static void exercicio3(){
        String a = JOptionPane.showInputDialog(null,"Digite valor do produto: ");
        double val = Double.parseDouble(a);
        if(val < 20){
        JOptionPane.showMessageDialog(null, "O valor do produto será: R$"+((val*0.45)+val),"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
        }else{
        JOptionPane.showMessageDialog(null, "O valor do produto será: R$"+((val*0.30)+val),"MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
        }
        }
        
        static void exercicio4(){
         String a = JOptionPane.showInputDialog(null,"Digite idade: ");
        int id = Integer.parseInt(a);
        if(id <16){
        JOptionPane.showMessageDialog(null, "Pessoa ainda NÃO É eleitor","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
        }else if((id>=18 && id<=65)){
        JOptionPane.showMessageDialog(null, "Pessoa é eleitor OBRIGATÓRIO","MENSSAGEM" ,JOptionPane.INFORMATION_MESSAGE);
        }else{
        JOptionPane.showMessageDialog(null, "Pessoa é eleitor FACULTATIVO ","MENSSAGEM" ,JOptionPane.INFORMATION_MESSAGE); 
        }
        }
        
        static void exercicio5(){
        String nome = JOptionPane.showInputDialog(null,"Digite seu nome: ");
        String a = JOptionPane.showInputDialog(null,"Digite sua idade: ");
        int id = Integer.parseInt(a);
        if(id <=10){
        JOptionPane.showMessageDialog(null,nome+" você pagará mensalmente R$ 30,00","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
        }else if(id<=29){
        JOptionPane.showMessageDialog(null,nome+" você pagará mensalmente R$ 60,00","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
        }else if(id<=45){
        JOptionPane.showMessageDialog(null,nome+" você pagará mensalmente R$ 120,00","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
        }else if(id<=59){
        JOptionPane.showMessageDialog(null,nome+" você pagará mensalmente R$ 150,00","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
        }else if(id<=65){
        JOptionPane.showMessageDialog(null,nome+" você pagará mensalmente R$ 250,00","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
        }else{
        JOptionPane.showMessageDialog(null,nome+" você pagará mensalmente R$ 400,00","MENSSAGEM", JOptionPane.INFORMATION_MESSAGE);
        }
        }
    
}
