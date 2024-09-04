using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Entidades04
{
    public class Publicacion
    {
        private string nombre;
        private decimal precio;

        // d. Constructor para inicializar los atributos
        public Publicacion(string nombre, decimal precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        // c. Métodos de acceso
        public string Nombre
        {
            get { return nombre; }
        }

        public decimal Precio
        {
            get { return precio; }
        }

        // e. Método MostrarDatos()
        public virtual string MostrarDatos()
        {
            return $"Nombre: {nombre}, Precio: {precio:C}";
        }

        // f. Sobrecarga del operador ==
        public static bool operator ==(Publicacion p1, Publicacion p2)
        {
            return p1?.nombre == p2?.nombre;
        }

        public static bool operator !=(Publicacion p1, Publicacion p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            return obj is Publicacion publicacion && nombre == publicacion.nombre;
        }

        public override int GetHashCode()
        {
            return nombre.GetHashCode();
        }
    }  
}
