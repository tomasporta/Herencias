using Herencia.Entidades02;

namespace Herencia.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrianguloEquilatero triangulo = new TrianguloEquilatero(5);
            Console.WriteLine($"Triángulo Equilátero - Lado: {triangulo.LongitudLado}, Perímetro: {triangulo.Perimetro()}, Superficie: {triangulo.Superficie()}");

            Cuadrado cuadrado = new Cuadrado(4);
            Console.WriteLine($"Cuadrado - Lado: {cuadrado.LongitudLado}, Perímetro: {cuadrado.Perimetro()}, Superficie: {cuadrado.Superficie()}");

            Pentagono pentagono = new Pentagono(6);
            Console.WriteLine($"Pentágono - Lado: {pentagono.LongitudLado}, Perímetro: {pentagono.Perimetro()}, Superficie: {pentagono.Superficie()}");

            Hexagono hexagono = new Hexagono(3);
            Console.WriteLine($"Hexágono - Lado: {hexagono.LongitudLado}, Perímetro: {hexagono.Perimetro()}, Superficie: {hexagono.Superficie()}");
        }
    }
}
