using System;

namespace Ex_2_2
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
        //visual da tabela
         Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.SetCursorPosition(20,0);
        Console.WriteLine("╔═══════════════════════╦══════════════════════════════════╦═════════════════════════╗");
        Console.SetCursorPosition(20,1);
        Console.WriteLine("║                       ║                                  ║                         ║");
        Console.SetCursorPosition(20,2);
        Console.WriteLine("║                       ╚══════════════════════════════════╝                         ║");
        Console.SetCursorPosition(20,3);
        Console.WriteLine("║                                                                                    ║");
        Console.SetCursorPosition(20,4);
        Console.WriteLine("║                                                                                    ║");
        Console.SetCursorPosition(20,5);
        Console.WriteLine("║                                                                                    ║");
        Console.SetCursorPosition(20,6);
        Console.WriteLine("║                                                                                    ║");
        Console.SetCursorPosition(20,7);
        Console.WriteLine("║                                                                                    ║");
        Console.SetCursorPosition(20,8);
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.BackgroundColor = ConsoleColor.White;
        Console.SetCursorPosition(46,1);
        Console.WriteLine("Conversão de Celsius em Kevin ☼");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.BackgroundColor = ConsoleColor.Yellow;
        //desenvolvimento, entrada e finalização
        Console.SetCursorPosition(22,3);
        Console.Write("Qual é a temperatura em graus Celsius? ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double kelvin = celsius + 273.15;
        Console.SetCursorPosition(22,6);
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("A temperatura na escala Kelvin é: "+kelvin+ "K.");
        Console.ReadKey();
        }//fim
    }
}
