using System;

namespace Ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {//variaveis
        double salario, salarioM, salarioT;
        //inicio
        //visual da tabela
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.SetCursorPosition(20,0);
        Console.WriteLine("╔═════════════════════╦═══════════════════════════════╦═══════════════════════╗");
        Console.SetCursorPosition(20,1);
        Console.WriteLine("║                     ║                               ║                       ║");
        Console.SetCursorPosition(20,2);
        Console.WriteLine("║                     ╚═══════════════════════════════╝                       ║");
        Console.SetCursorPosition(20,3);
        Console.WriteLine("║                                                                             ║");
        Console.SetCursorPosition(20,4);
        Console.WriteLine("║                                                                             ║");
        Console.SetCursorPosition(20,5);
        Console.WriteLine("║                                                                             ║");
        Console.SetCursorPosition(20,6);
        Console.WriteLine("║                                                                             ║");
        Console.SetCursorPosition(20,7);
        Console.WriteLine("║                                                                             ║");
        Console.SetCursorPosition(20,8);
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition(45,1);
        Console.WriteLine("Cálculo de Salários Mínimos");
        Console.SetCursorPosition(22,3);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.BackgroundColor = ConsoleColor.White;
        //entrada de dados
        Console.WriteLine("Qual o salário mínimo atualmente?");
        Console.SetCursorPosition(22,4);
        salarioM = Convert.ToDouble(Console.ReadLine());
        Console.SetCursorPosition(22,5);
        Console.WriteLine("Quanto você recebe por mês?");
        Console.SetCursorPosition(22,6);
        salario = Convert.ToDouble(Console.ReadLine());
        salarioT = 0;
        //desenvolvimento
        do {
             if(salario >= salarioM)
             {
              salario = salario - salarioM;
              salarioT = salarioT + 1;   
             }
         } while(salario >= salarioM);
        //finalização
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.SetCursorPosition(22,7);
        Console.WriteLine("Você recebe "+ salarioT+ " salários mínimos! ☺ ♫");
        Console.ReadKey();     
        }//fim
    }
}
