using System;

namespace Ex_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nome = Convert.ToString(Console.ReadLine());
            string nomeMI = nome.ToLower();
            int pos = nomeMI.IndexOf (" ");
            string email = nomeMI.Substring(0, pos);
            Console.WriteLine(email+"@fatec.sp.gov.br");
        }
    }
}
