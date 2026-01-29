
package Lista1;

import java.util.Scanner;
public class Lista1 {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner leitor = new Scanner(System.in);
        int exe = 1;
        while (exe != 0){ 
        System.out.print("Digite o número exercicio a ser executado(1 à 5)\n"
                + "para sair digite qualquer outro número:");
        exe = leitor.nextInt();
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
        }
   }
    
        static void exercicio1(){
        Scanner leitor = new Scanner(System.in);
        System.out.print("Digite nome do produto: ");
        String nomeP = leitor.nextLine();
        System.out.print("Digite valor unitário($) do produto: ");
        double valP = leitor.nextDouble();
        System.out.print("Novo valor do protudo "+nomeP+": "+ (valP-(valP*0.09))+"\n\n");
        }
    
        static void exercicio2(){
        Scanner leitor = new Scanner(System.in);
        System.out.print("Digite nome da pessoa: ");
        String nomeP = leitor.nextLine();
        System.out.print("Digite valor do salario minimo: ");
        double salmi = leitor.nextDouble();
        System.out.print("Digite valor do salario da pessoa: ");
        double salpe = leitor.nextDouble();
        float sal = (float) (salpe/salmi);
        System.out.print("o(a) "+nomeP+" recebe "+sal +" salario(s) por mês\n\n");
        }
        
        static void exercicio3(){
        Scanner leitor = new Scanner(System.in);
        System.out.print("Digite 1º valor: ");
        float val1 = leitor.nextFloat();
        System.out.print("Digite 2º valor: ");
        float val2 = leitor.nextFloat();
        System.out.print("Média dos valores digitados é = "+((val1+val2)/2)+"\n\n");
        }

        static void exercicio4(){
        Scanner leitor = new Scanner(System.in);
        System.out.print("Digite graus Centígrados: ");
        byte c = leitor.nextByte();
        System.out.print(c+"º Centígrados = "+((9*c+160)/5)+"º Fahrenheit\n\n");
        }
        
        static void exercicio5(){
        Scanner leitor = new Scanner(System.in);
        System.out.print("Digite valor da altura lata de óleo: ");
        float alt = leitor.nextFloat();
        System.out.print("Digite valor do raio da lata de óleo: ");
        float r = leitor.nextFloat();
        System.out.print("Volume da lata de óleo é: "+(3.14159*(r*r)*alt)+"\n\n");
        }
}