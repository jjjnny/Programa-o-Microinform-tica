using System;

namespace Ex_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, par;
            Console.WriteLine("Digite apenas números pares:");
            do {
            num = Convert.ToInt32(Console.ReadLine());
            par = num%2;
                if (par != 0) {
                    Console.WriteLine("Números ímpares não são permitidos!");
                }
            } while (par == 0);
            
        }
    }
}
