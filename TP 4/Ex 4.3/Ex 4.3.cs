using System;

namespace Ex_4_3
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            //variaveis
            int ano, anoNa, idade;
            //Desenvolvimento
            Console.WriteLine("Em que ano você está atualmente? ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Em que ano você nasceu? ");
            anoNa = Convert.ToInt32(Console.ReadLine());
            idade = ano - anoNa;
            Console.WriteLine("Você tem "+idade+" anos!");
            Console.ReadKey();
        }//fim
    }
}
