using System;
using System.Threading;

namespace Ex_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.Write("Digite um número: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num < 0) {
                Console.Write("O número precisa ser maior que zero!");
            }
            else {
                for (c = 1; c <= num; c++) {
                   Console.WriteLine(c); 
                }
            }

        }
    }
}
