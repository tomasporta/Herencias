using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades03
{
    public class Cuadrado : Figura
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public override double Perimetro()
        {
            return Lado * 4;
        }
        public override double Superficie()
        {
            return Lado * Lado;
        }

        public override bool Validar()
        {
            return Lado > 0;
        }
    }
}
