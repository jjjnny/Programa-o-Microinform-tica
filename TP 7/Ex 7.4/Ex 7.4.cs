using System;

namespace Ex_7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double maior, menor, flag;
            maior = 0;
            menor = 0;
            flag = 0;
            int c;
            for (c = 1; c <= 20; c++) {
                Console.WriteLine("Digite o "+c+"º número: ");
                double num = Convert.ToDouble(Console.ReadLine());
                    if (flag == 0) {
                        maior = num;
                        menor = num;
                        flag = 1;
                    }
                    if (num > maior) {
                            maior = num;
                    }
                    else
                    if (num < menor) {
                            menor = num;
                    }
            }
            Console.WriteLine("O maior número digitado foi: "+maior);
            Console.WriteLine("O menor número digitado foi: "+menor);
        }
    }
}
