using Facec.Classes;
using Facec.Extensoes;
using System;

namespace Facec.Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimirVelocidadeFinal(new Cooper());
            ImprimirVelocidadeFinal(new Fusca());

            ImprimirMembrosSerHumano(new Humano());

            Console.ReadLine();
        }

        static void ImprimirVelocidadeFinal(AbstractCarro carro)
        {
            Console.WriteLine(carro.ObterVelocidadeFinal());
        }

        static void ImprimirMembrosSerHumano(Humano humano)
        {
            Console.WriteLine($"{humano.Bracos} - {humano.Quadril}");
        }

        PosicaoGPS posicaoGPS = new PosicaoGPS()
        {
            Latitude = 50.00m,
            Longitude = -15.00m
        };

        
    }
}
