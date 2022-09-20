using System;

namespace Ex_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, soma;
            soma = 0;
            int c;
            for (c = 1; c <= 10; c++) {
                Console.WriteLine("Digite o "+c+"º número: ");
                num = Convert.ToDouble(Console.ReadLine());
                if (num >= 10) {
                    soma = soma + num;
                }
            }
            Console.WriteLine("O valor da soma dos números é: "+soma);
        }
    }
}
