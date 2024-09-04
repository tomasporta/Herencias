using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades
{
    public class Camion : VehiculoTerrestre
    {
        public short CantidadMarchas { get; set; }
        public int PesoCarga { get; set; }

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            CantidadMarchas = cantidadMarchas;
            PesoCarga = pesoCarga;
        }
    }
}
