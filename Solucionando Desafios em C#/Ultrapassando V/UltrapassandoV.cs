using System;

class UltrapassandoV {

  public static void Main () {
    var R = int.Parse(Console.ReadLine());
    var V = 0;
    var contador = 1;

    do {

      V = int.Parse(Console.ReadLine());

    } while (R >= V);
    
    int i = R;
    
    while (i <= V) {
      contador++;
      R += 1;
      i += R;
    }
    Console.WriteLine(contador);
    
  }
}