using Facec.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Extensoes
{   //uma classe static só pode ter métodos statics, uma classe normal pode ter ambos;
    public static class CarroExtensoes
    {
        public static string ObterVelocidadeFinal(this AbstractCarro carro)
        {
            return $"{carro.ObterMarca()} - {carro.ObterModelo()}: " +
                $"{carro.ObterVelocidade()} Km/h \n"; 
        }
    }
}
