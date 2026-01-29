
package com.mycompany.lista5;
public class Triangulo {
    double base, altura, area;
    public void SetTriangulo(double n1, double n2){
        base = n1;
        altura = n2;
    }
    public double GetArea(){
        area = (base*altura)/2;
        return area;
    }
}
