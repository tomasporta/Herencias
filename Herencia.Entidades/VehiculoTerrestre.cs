using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades
{
    public class VehiculoTerrestre
    {
        public short CantidadRuedas { get; set; }
        public short CantidadPuertas { get; set; }
        public Colores Color { get; set; }

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            CantidadRuedas = cantidadRuedas;
            CantidadPuertas = cantidadPuertas;
            Color = color;
        }
    }
}
