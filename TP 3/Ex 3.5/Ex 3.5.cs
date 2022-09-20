using System;

namespace Ex_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nomeC = Convert.ToString(Console.ReadLine());
            string nomeCMI = nomeC.ToLower();
            int pos1 = nomeCMI.IndexOf(" ");
            int pos2 = nomeCMI.LastIndexOf(" ");
            string nome = nomeCMI.Substring(0, pos1);
            string sobn = nomeCMI.Substring(pos2);
            string sobnE = sobn.Trim();
            Console.WriteLine(nome+"."+sobnE+"@fatec.sp.gov.br");
            Console.ReadKey();
        }
    }
}
