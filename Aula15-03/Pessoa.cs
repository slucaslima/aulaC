using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15_03
{
    class Pessoa
    {
        public string Nome { get; private set; }

        public Pessoa (string nome)
        {
            Nome = nome ??
                throw new ArgumentNullException(nameof(nome));
        }
    }
}
