using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades04
{
    public class Libro : Publicacion
    {
        // Atributo privado
        private int numeroPaginas;

        // Constructor
        public Libro(string nombre, decimal precio, int numeroPaginas)
            : base(nombre, precio)
        {
            this.numeroPaginas = numeroPaginas;
        }

        // Propiedad de acceso
        public int NumeroPaginas
        {
            get { return numeroPaginas; }
        }

        // Mostrar todos los datos
        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $", Páginas: {numeroPaginas}";
        }
    }
}
