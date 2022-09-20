using System;

namespace Ex_4_8
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            //variaveis
            double n1, n2, n3, media;
            //desenvolvimento
            Console.WriteLine("Digite três notas: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            media = (n1 * 2 + n2 * 3 + n3 * 5)/10;
            Console.WriteLine("Sua média é: "+media);
            Console.ReadKey();
        }//fim
    }
}
