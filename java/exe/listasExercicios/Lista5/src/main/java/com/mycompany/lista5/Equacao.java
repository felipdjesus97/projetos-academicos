/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.lista5;

import javax.swing.JOptionPane;

public class Equacao{
    int A, B, C;
    double D;
    double R1,R2;
    public void SetValores(int n1, int n2, int n3){
        A = n1;
        B = n2;
        C = n3;
    }
    public double GetDelta(){
        D = ((double)B*(double)B) - (4*(double)A*(double)C);
        return D;
    }
    public double GetR1(){
        R1 = (-(double)B + Math.sqrt(D))/(2*(double)A);
        String a =""+R1;
        if(a == "NaN"){
            R1 = 0;
        }
        return R1;
        
    }
    public double GetR2(){
        R2 = (-(double)B - Math.sqrt(D))/(2*(double)A);
        return R2;
    }
    public void Raizes(){
        if(D < 0){
            JOptionPane.showMessageDialog(null,"Não existem raizes reais:\nA: " 
                    + A + "\nB: " + B + "\nC: " + C + "\nDelta: " + D);
        }
        else if(D ==0 ){
            JOptionPane.showMessageDialog(null,"Como delta é zero a raiz so há uma:\nA: " 
                    + A + "\nB: " + B + "\nC: " + C + "\nDelta: " + D
                    + "\nRaiz: " + R1 );
        }
        else{
            JOptionPane.showMessageDialog(null,"existem 2 raízes diferentes:\nA: " 
                    + A + "\nB: " + B + "\nC: " + C + "\nDelta: " + D
                    + "\nRaiz 1: " + R1 + "\nRaiz 2: " + R2);
        }
    }
}


