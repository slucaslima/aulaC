using System;

namespace Aula15_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1 = "Lucas";
            string nome2 = nome1;

            nome1 = "Dog";

            Console.WriteLine($"{nameof(nome1)}:{nome1}");
            Console.WriteLine($"{nameof(nome2)}:{nome2}");

            Console.ReadLine();
        }
    }
}
