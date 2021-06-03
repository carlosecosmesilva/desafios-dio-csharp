using System;



public class PizzaAntesDoFinalDoAno
{
  public static void Main()
  {
    string[] line = Console.ReadLine().Split(" ");
    
    int N = int.Parse(line[0]);
    int D =  int.Parse(line[1]);
    int qtd = 0;
    bool achou = false;
    string dataConsiderada = " ";
    
    for (int dt = 0; dt < D; dt++)
    {
      qtd = 0;
      string[] entradaDataConfirmacao = Console.ReadLine().Split(" ");
      dataConsiderada = entradaDataConfirmacao[0];
      
      for (int p=1; p <N+1; p++)
      {
        qtd += int.Parse(entradaDataConfirmacao[p]);
      }
      
      achou = (qtd == N);
      
      if (achou)
      {
        break;
      }
    }
      if (achou)
      {
        Console.WriteLine(dataConsiderada);
        
      } 
      else {
        Console.WriteLine("Pizza antes de FdA");
    }
  }
}
