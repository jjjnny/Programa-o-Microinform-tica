using System;

namespace Ex_4_7
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            //variaveis
            double diaI, mesI, idade, idadeDias;
            //desenvolvimento
            Console.WriteLine("Digite sua idade em anos, meses e dias:");
            idade = Convert.ToDouble(Console.ReadLine());
            mesI = Convert.ToDouble(Console.ReadLine());
            diaI = Convert.ToDouble(Console.ReadLine());
            idadeDias = (idade * 365) + (mesI * 30) + diaI;
            Console.WriteLine("A sua idade em dias é: "+idadeDias);
            Console.ReadKey();
        }
    }
}
