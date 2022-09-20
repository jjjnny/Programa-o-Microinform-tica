using System;

namespace Ex_5._3
{
    class Program
    {
        static void Main(string[] args)
        {   
            double totalpaga;
            Console.Write("Qual o produto adquirido? ");
            string produto = Convert.ToString(Console.ReadLine());
            Console.Write("Quantas unidades você adquiriu? ");
            double quant = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual o preço unitário do produto? ");
            double preço = Convert.ToDouble(Console.ReadLine());
            double total = quant * preço;
            Console.WriteLine("O preço total da sua compra é: R$"+total);
            if (quant <= 5) {
                Console.WriteLine("Você recebeu recebeu 2% de desconto!");
                double desconto = total * 0.02;
                totalpaga = total - desconto;
                Console.WriteLine("O total a pagar é: R$"+totalpaga);
            }
            else
            if ((quant > 5 && quant <=10)) {
                Console.WriteLine("Você recebeu recebeu 3% de desconto!");
                double desconto = total * 0.03;
                totalpaga = total - desconto;
                Console.WriteLine("O total a pagar é: R$"+totalpaga);
            }
            else {
                Console.WriteLine("Você recebeu recebeu 5% de desconto!");
                double desconto = total * 0.05;
                totalpaga = total - desconto;
                Console.WriteLine("O total a pagar é: R$"+totalpaga);
            }
            Console.ReadKey();
        }
    }
}
