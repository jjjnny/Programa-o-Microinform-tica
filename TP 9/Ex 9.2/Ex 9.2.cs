using System;

namespace Ex_9._2
{
    class Program
    {
        public static void tri (int a, int b, int c) {
            if ((a+b) > c) {
                Console.WriteLine("Os valores formam um triângulo!");
            }else {
                Console.WriteLine("Os valores NÃO formam triângulo...");
            }
            
        }
        static void Main(string[] args)
        {
            Console.Write("Digite três valores: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            tri(a, b, c);
            
        }
    }
}
