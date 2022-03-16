using System;

namespace Facec.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractCarro carro1 = new Cooper();

            //Console.WriteLine(carro1.RelatorioDeManutencao());
            //Console.ReadLine();

            ImprimirRelatorioDeManutencao(new Cooper());
            ImprimirRelatorioDeManutencao(new Fusca());
            Console.ReadLine();
        }

        static void ImprimirRelatorioDeManutencao(AbstractCarro carro)
        {
            Console.WriteLine(carro.RelatorioDeManutencao() + "\n");
        }
    }
}
