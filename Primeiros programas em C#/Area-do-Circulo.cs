using System; 

class Classe {

    static void Main(string[] args)
    {

        double pi = 3.14159, r;
        double a;

        r = Convert.ToDouble(Console.ReadLine());
        a = Convert.ToDouble(Console.ReadLine());

      //insira o calculo da area de acordo com o solicitado
        

        Console.WriteLine("A=" + (  pi * r  *  r ).ToString("0.0000"));
    }


}