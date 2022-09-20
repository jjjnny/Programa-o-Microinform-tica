using System;

namespace Ex_2_5
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
        //visual tabela
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(20,0);
        Console.WriteLine("╔══════════════════════════════════════════════╗");
        Console.SetCursorPosition(20,1);
        Console.WriteLine("║                                              ║");
        Console.SetCursorPosition(20,2);
        Console.WriteLine("╠══════════════════════════════════════════════╣");
        Console.SetCursorPosition(20,3);
        Console.WriteLine("║                                              ║");
        Console.SetCursorPosition(20,4);   
        Console.WriteLine("╚══════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(22,1);
        Console.Write("Digite um número: ");
        double num = Convert.ToDouble(Console.ReadLine()); 
        if (num > 20) {
            num = num / 2;
            Console.SetCursorPosition(22,3);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("A metade do número digitado é igual a: "+num);
        }
        else {
            num = num * 2;
            Console.SetCursorPosition(22,3);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("O dobro do número digitado é igual a: "+num);
        }
        Console.ReadKey();
        }//fim
    }
}
