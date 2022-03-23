using Aula22_03._01___Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula22_03._02___Classes
{
    public class Abajur : IIluminacao
    {

        public void Desligar()
        {
            Console.WriteLine($"{nameof(Abajur)} Desligou!");
        }

        public void Ligar()
        {
            Console.WriteLine($"{nameof(Abajur)} Ligou!");
        }

        public void ObterPotenciaLampada()
        {
            Console.WriteLine($"{nameof(Abajur)} possui uma lâmpada de 100Wats de Potêcia!");
        }
    }
}
