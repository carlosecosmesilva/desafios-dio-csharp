using System;

class CardapioAereo {  
  public static void Main (string[] args) {
    string[] refeicoesDisponiveis = Console.ReadLine().Split(' ');
    int Ca = int.Parse(refeicoesDisponiveis[0]);
    int Ba = int.Parse(refeicoesDisponiveis[1]);
    int Pa = int.Parse(refeicoesDisponiveis[2]);

    string[] refeicoesRequisitadas = Console.ReadLine().Split(' ');
    int Cr = int.Parse(refeicoesRequisitadas[0]);
    int Br = int.Parse(refeicoesRequisitadas[1]);
    int Pr = int.Parse(refeicoesRequisitadas[2]);
    
    int somaTotal = 0;
    int CaCr = Ca - Cr;
    int BaBr = Ba - Br;
    int PaPr = Pa - Pr;

    if (CaCr<0)
      somaTotal = somaTotal + (CaCr * -1);

    if (BaBr<0)
      somaTotal = somaTotal + (BaBr * -1);

    if (PaPr<0)
      somaTotal = somaTotal + (PaPr * -1);

    Console.Write(somaTotal);
  } 
}