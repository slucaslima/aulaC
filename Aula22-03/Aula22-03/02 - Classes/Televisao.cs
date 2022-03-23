using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula22_03._01___Interfaces;

namespace Aula22_03._02___Classes
{
    public class Televisao : IEletroDomestico
    {

        public void Desligar()
        {
            Console.WriteLine($"{nameof(Televisao)} Desligou! \n");
        }

        public void Ligar()
        {
            Console.WriteLine($"{nameof(Televisao)} Ligou!");
        }

    }
}
