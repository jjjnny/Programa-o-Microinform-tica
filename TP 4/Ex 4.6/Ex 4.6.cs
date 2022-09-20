using System;

namespace Ex_4_6
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            //variaveis
            double baR, altura, area;
            //desenvolvimento
            Console.WriteLine("Qual a altura do retângulo?");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quanto mede a base do retângulo?");
            baR = Convert.ToDouble(Console.ReadLine());
            area = altura * baR;
            Console.WriteLine("O retângulo tem "+area+" cm².");
            Console.ReadKey();
        }
    }
}
