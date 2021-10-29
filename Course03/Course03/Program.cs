using System;
using System.Globalization;

namespace Course03
{
    class Program
    {

        

        static void Main(string[] args)
        {


            Console.WriteLine("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double result = Calculadora.DolarParaReal(quantia, cotacao);


            Console.WriteLine("Valor a ser pago em Reais = " + result.ToString("F2", CultureInfo.InvariantCulture));


        }

       
    }
}
