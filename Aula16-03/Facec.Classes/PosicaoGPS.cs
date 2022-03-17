using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Classes
{
    public struct PosicaoGPS
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        // Após a declaração de um construtor com params, não é possível declarar um construtor vazio.
        // public PosicaoGP() { }

        public PosicaoGPS(decimal latitude, decimal longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool IsHemisferioNorte()
        {
            return Latitude > 0;
        }
    }
}
