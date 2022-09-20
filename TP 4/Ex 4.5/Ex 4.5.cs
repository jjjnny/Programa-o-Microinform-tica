using System;

namespace Ex_4_5
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            //variaveis
            double n1, nA;
            //desenvolvimento
            Console.WriteLine("Digite um número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            nA = n1 - 1;
            Console.WriteLine("O antecessor de "+n1+" é "+nA+".");
            Console.ReadKey();
        }
    }
}
