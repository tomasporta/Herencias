﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades
{
    public class Moto : VehiculoTerrestre
    {
        public short Cilindrada { get; set; }

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            Cilindrada = cilindrada;
        }
    }
}
