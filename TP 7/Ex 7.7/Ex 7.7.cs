using System;

namespace Ex_7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, num, quant;
            c = 1;
            quant = 0;
            while (c <= 10) {
                Console.WriteLine("Digite o "+c+"º número: ");
                num = Convert.ToInt16(Console.ReadLine());
                c = c + 1;
                if (num < 0) {
                    quant = quant + 1;
                }
            }
            Console.WriteLine(quant+" dos números digitados são negativos!");
        }
    }
}
