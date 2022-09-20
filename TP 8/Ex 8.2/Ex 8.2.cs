using System;

namespace Ex_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, n1, n2, n3, n4, escolha;
            do {
                do {
                    Console.Write("Digite a 1º nota: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    if (n1 < 0 || n1 > 10) {
                        Console.WriteLine("Esta nota não é válida, digite novamente!");
                    }
                 } while (n1 < 0 || n1 > 10);
                 do {
                    Console.Write("Digite a 2º nota: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                        if (n2 < 0 || n2 > 10) {
                            Console.WriteLine("Esta nota não é válida, digite novamente! ");
                        }
                 } while (n2 < 0 || n2 > 10);
                 do {
                    Console.Write("Digite a 3º nota: ");
                    n3 = Convert.ToDouble(Console.ReadLine());
                        if (n3 < 0 || n3 > 10) {
                            Console.WriteLine("Esta nota não é válida, digite novamente! ");
                        }
                 } while (n3 < 0 || n3 > 10);
                 do {
                    Console.Write("Digite a 4º nota: ");
                    n4 = Convert.ToDouble(Console.ReadLine());
                        if (n4 < 0 || n4 > 10) {
                            Console.WriteLine("Esta nota não é válida, digite novamente! ");
                        }
                 } while (n4 < 0 || n4 > 10);
                media = (n1 + n2 + n3 + n4)/4;
                Console.WriteLine("Sua média é: "+media);
                do {
                    Console.Write("Deseja continuar? [1] Sim  [2] Não: ");
                    escolha = Convert.ToDouble(Console.ReadLine());
                    if (escolha < 1 || escolha > 2) {
                        Console.WriteLine("Esta não é uma opção válida, por favor digite novamente!");
                    }
                }while(escolha < 1 || escolha > 2);
            } while (escolha == 1);
        }
    }
}
