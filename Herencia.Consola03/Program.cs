using Herencia.Entidades03;
using System.Drawing;

namespace Herencia.Consola03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear lista de figuras
            List<Figura> figuras = new List<Figura>();

            // Crear y agregar las figuras a la lista
            Cuadrado cuadrado = new Cuadrado(4);
            Rectangulo rectangulo = new Rectangulo(5, 3);
            Triangulo triangulo = new Triangulo(3, 4, 5);
            Circunferencia circunferencia = new Circunferencia(2.5);

            figuras.Add(cuadrado);
            figuras.Add(rectangulo);
            figuras.Add(triangulo);
            figuras.Add(circunferencia);

            // Recorrer la lista y mostrar los datos de cada figura
            foreach (Figura figura in figuras)
            {
                if (figura.Validar())
                {
                    Console.WriteLine($"Figura: {figura.GetType().Name}");
                    Console.WriteLine($"Perímetro: {figura.Perimetro():F2}");
                    Console.WriteLine($"Superficie: {figura.Superficie():F2}");
                }
                else
                {
                    Console.WriteLine($"Figura: {figura.GetType().Name} no es válida.");
                }

                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
