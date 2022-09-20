using System;

namespace Ex_6._1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(25,2);
            Console.Write("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.SetCursorPosition(25,3);
            Console.Write("░░                                                                        ░░");
            Console.SetCursorPosition(25,4);
            Console.Write("░░          Seja bem vindo(a), selecione a operação que deseja:           ░░");
            Console.SetCursorPosition(25,5);
            Console.Write("░░                                                                        ░░");
            Console.SetCursorPosition(25,6);
            Console.Write("░░               [1] Bhaskara   [2] Força   [3] Velocidade                ░░");
            Console.SetCursorPosition(25,7);
            Console.Write("░░                                                                        ░░");
            Console.SetCursorPosition(25,8);
            Console.Write("░░                           Sua escolha é: [ ]                           ░░");
            Console.SetCursorPosition(25,9);
            Console.Write("░░                                                                        ░░");
            Console.SetCursorPosition(25,10);
            Console.Write("░░                                                                        ░░");
            Console.SetCursorPosition(25,11);
            Console.Write("░░                                                                        ░░");
            Console.SetCursorPosition(25,12);
            Console.Write("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.SetCursorPosition(70,8);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha) {
                case 1:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(25,2);
                    Console.Write("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                    Console.SetCursorPosition(25,3);
                    Console.Write("░░                                                                        ░░");
                    Console.SetCursorPosition(25,4);
                    Console.Write("░░                                                                        ░░");
                    Console.SetCursorPosition(25,5);
                    Console.Write("░░                                                                        ░░");
                    Console.SetCursorPosition(25,6);
                    Console.Write("░░                                                                        ░░");
                    Console.SetCursorPosition(25,7);
                    Console.Write("░░                                                                        ░░");
                    Console.SetCursorPosition(25,8);
                    Console.Write("░░                                                                        ░░");
                    Console.SetCursorPosition(25,9);
                    Console.Write("░░                                                                        ░░");
                    Console.SetCursorPosition(25,10);
                    Console.Write("░░                                                                        ░░");
                    Console.SetCursorPosition(25,11);
                    Console.Write("░░                                                                        ░░");
                    Console.SetCursorPosition(25,12);
                    Console.Write("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.SetCursorPosition(49,4);
                    Console.Write("Você selecionou Bhaskara!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(28,6);
                    Console.Write("Digite o valor de A: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(28,7);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Digite o valor de B: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(28,8);
                    Console.Write("Digite o valor de C: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    double c = Convert.ToDouble(Console.ReadLine());
                    double delta = Math.Pow(b, 2) - 4 * a * c;
                    double x1 = (-b + Math.Sqrt(delta))/(2*a);
                    double x2 = (-b - Math.Sqrt(delta))/(2*a);
                    if (delta > 0) {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(28,9);
                        Console.Write("X1: "+x1);
                        Console.SetCursorPosition(28,10);
                        Console.Write("X2: "+x2);
                        Console.ReadKey();
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(28,10);
                        Console.Write("O delta é negativo! Esta equação não possui raízes reais!");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(25,2);
                    Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.SetCursorPosition(25,3);
                    Console.Write("▒▒                                                                        ▒▒");
                    Console.SetCursorPosition(25,4);
                    Console.Write("▒▒                                                                        ▒▒");
                    Console.SetCursorPosition(25,5);
                    Console.Write("▒▒                                                                        ▒▒");
                    Console.SetCursorPosition(25,6);
                    Console.Write("▒▒                                                                        ▒▒");
                    Console.SetCursorPosition(25,7);
                    Console.Write("▒▒                                                                        ▒▒");
                    Console.SetCursorPosition(25,8);
                    Console.Write("▒▒                                                                        ▒▒");
                    Console.SetCursorPosition(25,9);
                    Console.Write("▒▒                                                                        ▒▒");
                    Console.SetCursorPosition(25,10);
                    Console.Write("▒▒                                                                        ▒▒");
                    Console.SetCursorPosition(25,11);
                    Console.Write("▒▒                                                                        ▒▒");
                    Console.SetCursorPosition(25,12);
                    Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(51,4);
                    Console.Write("Você selecionou Força!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(28,6);
                    Console.Write("Digite o valor da massa: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    double massa = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(28,7);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Digite o valor de aceleração: ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    double ace = Convert.ToDouble(Console.ReadLine());
                    double força = massa * ace;
                    Console.SetCursorPosition(28,9);
                    Console.Write("O valor da força é: "+força);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.SetCursorPosition(25,2);
                    Console.Write("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.SetCursorPosition(25,3);
                    Console.Write("▓▓                                                                        ▓▓");
                    Console.SetCursorPosition(25,4);
                    Console.Write("▓▓                                                                        ▓▓");
                    Console.SetCursorPosition(25,5);
                    Console.Write("▓▓                                                                        ▓▓");
                    Console.SetCursorPosition(25,6);
                    Console.Write("▓▓                                                                        ▓▓");
                    Console.SetCursorPosition(25,7);
                    Console.Write("▓▓                                                                        ▓▓");
                    Console.SetCursorPosition(25,8);
                    Console.Write("▓▓                                                                        ▓▓");
                    Console.SetCursorPosition(25,9);
                    Console.Write("▓▓                                                                        ▓▓");
                    Console.SetCursorPosition(25,10);
                    Console.Write("▓▓                                                                        ▓▓");
                    Console.SetCursorPosition(25,11);
                    Console.Write("▓▓                                                                        ▓▓");
                    Console.SetCursorPosition(25,12);
                    Console.Write("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(49,4);
                    Console.Write("Você selecionou velocidade!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(28,6);
                    Console.Write("Digite o valor da velocidade inicial: ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    double velo_ini = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(28,7);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Digite o valor da aceleração constante: ");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    double ace_con = Convert.ToDouble(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(28,8);
                    Console.Write("Digite o valor do instante: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    double temp = Convert.ToDouble(Console.ReadLine());
                    double velo_fim = velo_ini + ace_con * temp;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.SetCursorPosition(28,10);
                    Console.Write("A velocidade será de: "+velo_fim);
                    Console.ReadKey();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition (49,10);
                    Console.Write("Selecione uma opção válida!");
                    Console.ReadKey();
                    break;            
            }

            
        }
    }
}
