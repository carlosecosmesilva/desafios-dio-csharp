using System;

 class MinhaClasse {
        static void Main(string[] args) {
            
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

//continue a solucao com a insercao da variavel corretamente

            if (A % B  == 0 || B % A == 0 ) {
                Console.WriteLine("São Multiplos");
            }
            else {
                Console.WriteLine("Não são Multiplos");
            }
        }
    }