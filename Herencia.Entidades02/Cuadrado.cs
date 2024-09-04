using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades02
{
    public class Cuadrado : PoligonoRegular
    {
        public Cuadrado(double longitudLado) : base(4, longitudLado) { }

        public override double Superficie()
        {
            return LongitudLado * LongitudLado;
        }
    }
}
