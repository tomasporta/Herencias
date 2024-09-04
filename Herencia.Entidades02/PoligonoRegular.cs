using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades02
{
     public abstract class PoligonoRegular
    {
        public int CantidadLados { get; protected set; }
        public double LongitudLado { get; protected set; }

        public PoligonoRegular(int cantidadLados, double longitudLado)
        {
            CantidadLados = cantidadLados;
            LongitudLado = longitudLado;
        }

        public double Perimetro()
        {
            return CantidadLados * LongitudLado;
        }

        public abstract double Superficie();
    }
}
