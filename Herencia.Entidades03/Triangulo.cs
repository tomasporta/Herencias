using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades03
{
    public class Triangulo : Figura
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public override double Perimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public override double Superficie()
        {
            double s = Perimetro() / 2;
            return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
        }

        public override bool Validar()
        {
            return LadoA + LadoB > LadoC && LadoB + LadoC > LadoA && LadoA + LadoC > LadoB;
        }
    }
}
