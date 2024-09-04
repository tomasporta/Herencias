using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades02
{
    public class TrianguloEquilatero: PoligonoRegular
    {
        public TrianguloEquilatero(double longitudLado) : base(3, longitudLado) { }

        public override double Superficie()
        {
            double altura = (Math.Sqrt(3) / 2) * LongitudLado;
            return (LongitudLado * altura) / 2;
        }
    }
}
