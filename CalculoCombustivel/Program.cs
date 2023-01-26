using System;

namespace CalculoCombustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gasolina = 1.80;
            double alcool = 1.00;
            double tanque, valorFinal;
            char combustivel;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**********************************");
            Console.WriteLine("** Informe o Tipo de Combustivel**");
            Console.WriteLine("****G - Gasolina |  A - Alcool****");
            Console.WriteLine("**********************************");
            combustivel = char.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("** Digite a capacidade do Tanque **");
            tanque = double.Parse(Console.ReadLine());
            Console.ResetColor();

            if (combustivel == 'G' || combustivel == 'g')
            {
                valorFinal = gasolina * tanque;
                Console.WriteLine("Valor a ser pago: " + valorFinal);
            }
            else if (combustivel == 'A' || combustivel == 'a')
            {
                valorFinal = alcool * tanque;
                Console.WriteLine("Valor a ser pago: " + valorFinal);
            }
            else
            {
                Console.WriteLine("OPÇÃO INEXISTENTE");
            }

            Console.ReadKey();
        }
    }
}
