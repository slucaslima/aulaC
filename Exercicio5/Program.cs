using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            int resul = 0;
            try
            {
                do
                {
                    Console.WriteLine("Digite um número:");
                    num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite outro número:");
                    num2 = double.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("1 -> Para SOMAR");
                    Console.WriteLine("2 -> Para SUBTRAIR");
                    Console.WriteLine("3 -> Para DIVIDIR");
                    Console.WriteLine("4 -> Para MULTIPLICAR");
                    Console.WriteLine("5 -> Para RESTO de Divisão");
                    Console.WriteLine("6 -> Para SAIR");

                    resul = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (resul)
                    {
                        case 1:
                            Console.WriteLine($"{num1} {'+'} {num2} = {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine($"{num1} {'-'} {num2} = {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine($"{num1} {'/'} {num2} = {num1 / num2}");
                            break;
                        case 4:
                            Console.WriteLine($"{num1} {'*'} {num2} = {num1 * num2}");
                            break;
                        case 5:
                            Console.WriteLine($"{num1} {'%'} {num2} = {num1 % num2}");
                            break;
                        case 6:
                            break;
                        default:
                            Console.WriteLine("Informação inserida não é um número válido!");
                            break;
                    }
                    if (resul != 6)
                    {
                        Console.WriteLine("Deseja continuar realizando outro cálculo (y/n)?");
                        string continuar = Console.ReadLine();

                        if (continuar == "n")
                        {
                            break;
                        }
                        Console.Clear();
                    }
                } while (resul != 6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
