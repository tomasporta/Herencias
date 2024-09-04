using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades03
{
    public class Rectangulo : Figura
    {
        public double LadoMayor { get; set; }
        public double LadoMenor { get; set; }

        public Rectangulo(double ladoMayor, double ladoMenor)
        {
            LadoMayor = ladoMayor;
            LadoMenor = ladoMenor;
        }

        public override double Perimetro()
        {
            return 2 * LadoMayor + 2 * LadoMenor;
        }

        public override double Superficie()
        {
            return LadoMayor * LadoMenor;
        }

        public override bool Validar()
        {
            return LadoMayor > 0 && LadoMenor > 0;
        }
    }
}
