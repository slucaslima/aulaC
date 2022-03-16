using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Classes
{
    public class Fusca : AbstractCarro
    {
        public override string ObterMarca()
        {
            return "Volkswagen";
        }

        public override string ObterModelo()
        {
            return "Fusca";
        }

        public override int ObterVelocidade()
        {
            return 140;
        }
    }
}
