using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        public short CantidadMarchas { get; set; }
        public int CantidadPasajeros { get; set; }

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            CantidadMarchas = cantidadMarchas;
            CantidadPasajeros = cantidadPasajeros;
        }
    }
}
