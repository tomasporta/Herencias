using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades03
{
    public class Circunferencia : Figura
    {
        public double Radio { get; set; }

        public Circunferencia(double radio)
        {
            Radio = radio;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override double Superficie()
        {
            return Math.PI * Radio * Radio;
        }

        public override bool Validar()
        {
            return Radio > 0;
        }
    }
}
