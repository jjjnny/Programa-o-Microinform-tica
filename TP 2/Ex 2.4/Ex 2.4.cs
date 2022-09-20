using System;

namespace Ex_2_4
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
        //variaveis
        double quilo, gramas, quiloA, gramasA;
        //visual da tabela
         Console.BackgroundColor = ConsoleColor.Magenta;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.SetCursorPosition(20,0);
        Console.WriteLine("╔═══════════════════════╦════════════════════╦═════════════════════════╗");
        Console.SetCursorPosition(20,1);
        Console.WriteLine("║                       ║                    ║                         ║");
        Console.SetCursorPosition(20,2);
        Console.WriteLine("║                       ╚════════════════════╝                         ║");
        Console.SetCursorPosition(20,3);
        Console.WriteLine("║                                                                      ║");
        Console.SetCursorPosition(20,4);
        Console.WriteLine("║                                                                      ║");
        Console.SetCursorPosition(20,5);
        Console.WriteLine("║                                                                      ║");
        Console.SetCursorPosition(20,6);
        Console.WriteLine("║                                                                      ║");
        Console.SetCursorPosition(20,7);
        Console.WriteLine("║                                                                      ║");
        Console.SetCursorPosition(20,8);
        Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(46,1);
        Console.WriteLine("Consulta de peso:");
        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.SetCursorPosition(22,3);
        Console.Write("Digite seu peso em quilos: ");
        quilo = Convert.ToDouble(Console.ReadLine());
        gramas = quilo * 1000;
        quiloA = (quilo * 0.10) + quilo;
        gramasA = (gramas * 0.10) + gramas;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.SetCursorPosition(22,4);
        Console.WriteLine("Seu peso em gramas é: "+gramas);
        Console.SetCursorPosition(22,5);
        Console.WriteLine("Seu peso em quilos com um acréscimo de 10%: "+quiloA);
        Console.SetCursorPosition(22,6);
        Console.WriteLine("Seu peso em gramas com um acréscimo de 10%: "+gramasA);
        Console.ReadKey();
        }
    }
}
