using System;

namespace Ex_2_3
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
        //visual da tabela
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.SetCursorPosition(20,0);
        Console.WriteLine("╔═════════════════╦══════════════════════════════════════╦═══════════════════╗");
        Console.SetCursorPosition(20,1);
        Console.WriteLine("║                 ║                                      ║                   ║");
        Console.SetCursorPosition(20,2);
        Console.WriteLine("║                 ╚══════════════════════════════════════╝                   ║");
        Console.SetCursorPosition(20,3);
        Console.WriteLine("║                                                                            ║");
        Console.SetCursorPosition(20,4);
        Console.WriteLine("║                                                                            ║");
        Console.SetCursorPosition(20,5);
        Console.WriteLine("║                                                                            ║");
        Console.SetCursorPosition(20,6);
        Console.WriteLine("║                                                                            ║");
        Console.SetCursorPosition(20,7);
        Console.WriteLine("║                                                                            ║");
        Console.SetCursorPosition(20,8);
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.SetCursorPosition(40,1);
        Console.WriteLine("Conversão de Fahrenheit em Celsius ☼");
        //desenvolvimento codigo, entrada e finalização
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.SetCursorPosition(22,3);
        Console.Write("Digite a temperatura em graus Fahrenheit: ");
        double fah = Convert.ToDouble(Console.ReadLine());
        double celsius = (fah - 32)/ 1.8;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.SetCursorPosition(22,5);
        Console.Write("A temperatura em graus Celsius é: "+celsius+"°C.");
        Console.ReadKey();
        }
    }
}
