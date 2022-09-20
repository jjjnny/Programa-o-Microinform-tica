using System;

namespace Ex_8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma;
            soma = 0;
            Console.WriteLine("Digite alguns números: ");
            do {
                num = Convert.ToInt32(Console.ReadLine());
                soma = soma + num;
            } while(num != 0);
            Console.WriteLine("A soma dos números é: "+soma);
        }
    }
}
