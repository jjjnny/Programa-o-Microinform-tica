using System;

namespace Ex_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if ((num%7 == 0 && num%3 == 0)) {
                Console.Write("O número digitado é múltiplo de 3 e 7!");
            }
            else {
                Console.Write("O número digitado NÃO É múltiplo de 3 e 7!");
            }
            Console.ReadKey();
        }
    }
}
