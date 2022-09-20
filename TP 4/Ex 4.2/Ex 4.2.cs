using System;

namespace Ex_4_2_
{
    class Program
    {
         static void Main(string[] args)
        {//inicio
            //DESENVOLVIMENTO CÓDIGO
            double a, b, c, d, e, f;
            Console.WriteLine("Digite dois números:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = a + b;
            d = a - b;
            e = a * b;
            f = a/b;
            Console.WriteLine(a+" + "+b+" = "+c);
            Console.WriteLine(a+" - "+b+" = "+d);
            Console.WriteLine(a+" x "+b+" = "+e);
            Console.WriteLine(a+" / "+b+" = "+f);
            Console.ReadKey();
        }//fim
    }   
}
