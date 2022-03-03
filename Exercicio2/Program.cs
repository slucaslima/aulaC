using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em $: ");

            string valorDigitado = Console.ReadLine();
            decimal valorConvertido = 0.0m;
            decimal valorCambio = 5.22m;

            decimal.TryParse(valorDigitado, out valorConvertido);

            decimal valorCambioConvertido = valorConvertido * valorCambio;

            Console.WriteLine($"Valor em R$: {valorCambioConvertido}");
            Console.ReadLine();


        }
    }
}
