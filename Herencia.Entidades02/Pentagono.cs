﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades02
{
    public  class Pentagono : PoligonoRegular
    {
        public Pentagono(double longitudLado) : base(5, longitudLado) { }

        public double Apotema()
        {
            return Math.Sqrt((LongitudLado * LongitudLado) - (Math.Pow(LongitudLado / 2, 2)));
        }

        public override double Superficie()
        {
            return (Perimetro() * Apotema()) / 2;
        }
    }
}
