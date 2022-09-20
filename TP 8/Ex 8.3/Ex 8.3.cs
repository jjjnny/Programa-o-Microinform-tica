using System;

namespace Ex_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite alguns números: ");
            do {
                num = Convert.ToInt32(Console.ReadLine());
            } while (num > 1);
        }
    }
}
