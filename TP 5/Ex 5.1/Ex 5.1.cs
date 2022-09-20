using System;

namespace Ex_5._1
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            Console.Write("Qual seu valor de vendas realizados neste mês? ");
            double venda = Convert.ToDouble(Console.ReadLine());
            if ((venda >= 1000 && venda <3000 )){
                Console.Write("Você recebeu o prêmio de R$150,00!");
            }
            else 
            if (venda < 1000) {
                Console.Write("Lamento, você não recebeu nenhum prêmio...");
            }
            else {
                Console.Write("Parabés! Você recebeu o prêmio de R$300,00!");
            }
            Console.ReadKey();
        }//fim
    }
}
