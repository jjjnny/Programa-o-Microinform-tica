using System;

namespace Ex_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = Convert.ToDouble(Console.ReadLine());
            int c;
            for (c = 0; c <= 10; c++) {
               double result = num * c;
               Console.WriteLine(num+" x "+c+" = "+result);
            }
        }
    }
}
