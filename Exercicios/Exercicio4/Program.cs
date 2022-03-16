using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe a sua data de nascimento:");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Sua idade é de: " + $"{DateTime.Today.Year - date.Year} anos!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.ReadLine();
            }

            

          
        }
    }
}
