
package com.mycompany.lista7;

public class Tecnico extends Superior {
    
    @Override
  public double CalculaMedia( boolean tipo){
        return super.CalculaMedia(tipo);
    }

  public Tecnico(double n1,double n2, double n3) {
      super(n1, n2, n3);
  }
}
