using System;

namespace Ex_4_4
{
    class Program
    {
        static void Main(string[] args)
        {//inicio]
            //variaveis
            double n1, n2, n3, media;
            //Desenvolvimento
            Console.WriteLine("Digite 3 números: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            media = (n1 + n2 + n3)/3;
            Console.WriteLine("A média aritmética dos números digitados é: "+media);
            Console.ReadKey();
        }
    }
}
