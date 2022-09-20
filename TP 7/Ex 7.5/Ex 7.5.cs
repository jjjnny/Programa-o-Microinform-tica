using System;

namespace Ex_7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ini, fim;
            Console.Write("Digite um número para começar a sequência: ");
            ini = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite um número para finalizar a sequência: ");
            fim = Convert.ToInt16(Console.ReadLine());
            ini = ini - 1;
             while (ini < fim) { 
             ini++;
            Console.WriteLine(ini);
             } 
        }
    }
}
