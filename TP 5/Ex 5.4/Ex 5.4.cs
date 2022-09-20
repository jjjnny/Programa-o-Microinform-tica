using System;

namespace Ex_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua terceira nota: ");
            double n3 = Convert.ToDouble(Console.ReadLine());
            double media = (n1 * 0.25)+(n2 * 0.25)+(n3 * 0.50);
            if (media >= 9.0) {
                Console.Write("CONCEITO A");
            }
            else
            if ((media >=7.5 && media < 9.0)) {
                Console.Write("CONCEITO B");
            } 
            else
            if ((media >= 6.0 && media < 7.5)) {
                Console.Write("CONCEITO C");
            }
            else {
                Console.Write("CONCEITO D");
            }
            Console.ReadKey();
        }
    }
}
