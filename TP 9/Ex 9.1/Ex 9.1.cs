using System;

namespace Ex_9._1
{
    class Program
    {
        public static double soma (double n1, double n2) {
            return n1 + n2;
        }
        public static double sub (double n1, double n2) {
            return n1 - n2;
        }
        public static double mult (double n1, double n2) {
            return n1 * n2;
        }
        public static double div (double n1, double n2) {
            return n1 / n2;
        }
        static void Main(string[] args)
        {
            double escolha, result, n1, n2;
            Console.WriteLine("Escolha a operação ao qual deseja:");
            Console.WriteLine("[1] Soma  [2] Subtração  [3] Multiplicação  [4] Divisão: ");
            escolha = Convert.ToDouble(Console.ReadLine());
            switch (escolha) {
                case 1:
                Console.WriteLine("Digite dois números: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                n2 = Convert.ToDouble(Console.ReadLine());
                result = soma (n1,n2);
                Console.Write("A soma dos números é: "+result);
                break;
                case 2:
                Console.WriteLine("Digite dois números: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                n2 = Convert.ToDouble(Console.ReadLine());
                result = sub (n1,n2);
                Console.Write("A subtração dos números é: "+result);
                break;
                case 3:
                Console.WriteLine("Digite dois números: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                n2 = Convert.ToDouble(Console.ReadLine());
                result = mult (n1,n2);
                Console.Write("A multiplicação dos números é: "+result);
                break;
                case 4:
                Console.WriteLine("Digite dois números: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                n2 = Convert.ToDouble(Console.ReadLine());
                result = div (n1,n2);
                Console.Write("A divisão dos números é: "+result);
                break;
            }

        }
    }
}
