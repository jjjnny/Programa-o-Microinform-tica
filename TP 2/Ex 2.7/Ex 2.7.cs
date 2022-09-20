using System;

namespace Ex_2_7
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20,0);
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(20,1);
            Console.WriteLine("║                                                                          ║");
            Console.SetCursorPosition(20,2);
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(20,3);
            Console.WriteLine("║                                                                          ║");
            Console.SetCursorPosition(20,4);   
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════════════╣");
            Console.SetCursorPosition(20,5);
            Console.WriteLine("║                                                                          ║");
            Console.SetCursorPosition(20,6);
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(22,1);
            Console.Write("Digite seu salário: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(22,3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o valor de empréstimo desejado: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            double emp = Convert.ToDouble(Console.ReadLine());
            if (emp < salario * 0.3) {
                Console.SetCursorPosition(22,5);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Você pode receber o seu empréstimo!");
            }
            else {
                Console.SetCursorPosition(22,5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Você não pode receber o empréstimo, por favor digite um valor menor.");
            }
            Console.ReadKey();
        }//fim
    }
}
