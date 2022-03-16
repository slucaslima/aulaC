using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distância percorrida em KM:");
            string distanciaPercorrida = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de combústivel utilizada em Litros:");
            string combustivelUtilizado = Console.ReadLine();

            decimal distanciaConvertida = 0.0m;
            decimal combustivelConvertido = 0.0m;

            decimal.TryParse(distanciaPercorrida, out distanciaConvertida);
            decimal.TryParse(combustivelUtilizado, out combustivelConvertido);

            decimal consumoFinal = distanciaConvertida / combustivelConvertido;

            Console.WriteLine($"O consumo do veículo foi de: {consumoFinal} Km/L");
            Console.ReadLine();
        }
    }
}
