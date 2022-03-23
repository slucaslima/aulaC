using Aula22_03._01___Interfaces;
using Aula22_03._02___Classes;
using System;

namespace Aula22_03
{
    class Program
    {
        static void Main(string[] args)
        {
            IEletroDomestico eletro1 = new Televisao();

            eletro1.Ligar();
            eletro1.Desligar();

            IIluminacao eletro2 = new Abajur();

            eletro2.Ligar();
            eletro2.Desligar();
            eletro2.ObterPotenciaLampada();

            Console.ReadLine();
        }
    }
}
