using System;

namespace Ex_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double delta = Math.Pow(b, 2) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta))/(2*a);
            double x2 = (-b - Math.Sqrt(delta))/(2*a);
            Console.WriteLine("O valor de x1 é: "+x1);
            Console.WriteLine("O valor de x2 é: "+x2);
            Console.ReadKey();
        }
    }
}
