using System;

namespace Ex_4_1
{
    class Program
    {
         static void Main(string[] args)
        {//inicio
            //DESENVOLVIMENTO CÓDIGO
            string nome;
            Console.WriteLine("Digite seu nome: ");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Seja bem vindo(a), "+nome+".");
            Console.ReadKey();
        }//fim
    }   
}