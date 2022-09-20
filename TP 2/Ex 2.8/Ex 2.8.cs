using System;

namespace Ex_2_8
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
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
            Console.ForegroundColor = ConsoleColor.Magenta;
            double num = Convert.ToDouble(Console.ReadLine());
            if (num > 0) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(22,3);
                Console.Write("O número digitado é positivo!");
            }
            else 
            if (num == 0) {
                Console.SetCursorPosition(22,3);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("O número digitado é 0!");
            }
            else {
                Console.SetCursorPosition(22,3);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("O número digitado é negativo!");
            }
            Console.ReadKey();
        }//fim
    }
}
