using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Classes
{
    public abstract class AbstractCarro
    {

        public abstract string ObterMarca();
        public abstract string ObterModelo();
        public abstract int ObterVelocidade();


        // sem o virtual na declaração do método abaixo, ele não poderia ser sobrescrito;
        public virtual string RelatorioDeManutencao()
        {
            return $"{ObterMarca()} -" +
                $" {ObterModelo()} \n" +
                $"Teste Teste";
        }

    }
}
