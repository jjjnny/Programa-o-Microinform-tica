using System;

namespace Ex_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nomeC = Convert.ToString(Console.ReadLine());
            int pos = nomeC.IndexOf(" ");
            string nome = nomeC.Substring(0, pos);
            string sobn = nomeC.Substring(pos);
            string car = nomeC.Substring (5,10);
            string troca = nomeC.Replace("a", "o");
            Console.WriteLine("Seu primeiro nome: "+nome);
            Console.WriteLine("Seu sobrenome: "+sobn); 
            Console.WriteLine("Caractere do 5 ao 10: "+car);
            Console.WriteLine("Trocar os caracteres 'A' por 'O': "+troca);
            Console.ReadKey();
        }
    }
}
