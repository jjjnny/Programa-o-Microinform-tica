using System;

namespace Ex_7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, idade, quant;
            c = 0;
            quant = 0;
            while (c <= 10) {
            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            c = c + 1;
                if (idade > 18) {
                    quant = quant + 1;
                }
            }
            Console.WriteLine(quant+" das pessoas que digitarem são maiores de idade!");
        }
    }
}
