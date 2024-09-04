using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades04
{
    public class CD : Publicacion
    {
        // Atributo privado
        private double tiempoReproduccion;

        // Constructor
        public CD(string nombre, decimal precio, double tiempoReproduccion)
            : base(nombre, precio)
        {
            this.tiempoReproduccion = tiempoReproduccion;
        }

        // Propiedad de acceso
        public double TiempoReproduccion
        {
            get { return tiempoReproduccion; }
        }

        // Mostrar todos los datos
        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $", Tiempo de reproducción: {tiempoReproduccion} minutos";
        }
    }
}
