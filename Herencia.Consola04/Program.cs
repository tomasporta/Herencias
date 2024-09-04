using Herencia.Entidades04;
using System.Runtime.Serialization.Formatters.Binary;

namespace Herencia.Consola04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Publicacion> repositorio = new List<Publicacion>();

            // Capturar datos para un libro
            Console.WriteLine("Ingrese los datos del Libro:");
            Console.Write("Nombre: ");
            string nombreLibro = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precioLibro = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Número de Páginas: ");
            int paginas = Convert.ToInt32(Console.ReadLine());

            Libro libro = new Libro(nombreLibro, precioLibro, paginas );
            repositorio.Add(libro);

            // Capturar datos para un CD
            Console.WriteLine("\nIngrese los datos del CD:");
            Console.Write("Nombre: ");
            string nombreCD = Console.ReadLine();
            Console.Write("Precio: ");
            decimal precioCD = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Tiempo de Reproducción (en minutos): ");
            double tiempo = Convert.ToDouble(Console.ReadLine());

            CD cd = new CD(nombreCD, precioCD, tiempo);
            repositorio.Add(cd);

            // Mostrar las publicaciones
            Console.WriteLine("\nPublicaciones en el repositorio:");
            foreach (var publicacion in repositorio)
            {
                Console.WriteLine(publicacion.MostrarDatos());
            }


           
        }
    } 
}

