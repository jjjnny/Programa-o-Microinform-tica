using System;

namespace Ex_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20,0);
            Console.WriteLine("╔════════════════════════════════╗");
            Console.SetCursorPosition(20,1);
            Console.WriteLine("║                                ║");
            Console.SetCursorPosition(20,2);
            Console.WriteLine("╠════════════════════════════════╣");
            Console.SetCursorPosition(20,3);
            Console.WriteLine("║                                ║");
            Console.SetCursorPosition(20,4);   
            Console.WriteLine("╚════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(22,1);
            Console.Write("Digite um número: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num%5==0) {
                Console.SetCursorPosition(22,3);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("O número é múltiplo de 5!");
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(22,3);
                Console.Write("O número não é múltiplo de 5!");
            }
            Console.ReadKey();
        }
    }
}
