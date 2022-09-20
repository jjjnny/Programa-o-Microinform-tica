using System;

namespace Ex_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio do círculo: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            double A = Math.PI * Math.Pow(raio, 2);
            double D = raio * 2;
            double P = 2 * Math.PI * raio;
            Console.WriteLine("A área do círculo é: "+A);
            Console.WriteLine("O diâmetro do círculo: "+D);
            Console.WriteLine("O perímetro do círculo é: "+P);
            Console.ReadKey();
        }
    }
}
