using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Informe seu nome:");
                var name = Console.ReadLine();

                Console.WriteLine("Informe sua data de nascimento em dd/mm/YY:");
                var date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine(ObterMensagemFaixaEtaria(name, date));

            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            } 
            finally
            {
                Console.ReadLine();
            }


        }

        private static string ObterMensagemFaixaEtaria(string name, DateTime date)
        {
            var idade = DateTime.Today.Year - date.Year;

            if (idade >= 60)
                return $"Olá {name}, você possui {idade} anos e está na faixa etária de Idosos!";
            else if (idade >= 20 && idade <= 59)
                return $"Olá {name}, você possui {idade} anos e está na faixa etária de Adultos!";

            return $"Olá {name}, você possui {idade} anos e está na faixa etária de Jovens!";
        }
    }
}
