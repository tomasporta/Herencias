using System.Drawing;
using System;
using Herencia.Entidades;

namespace Herencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(6, 2, Colores.Azul, 8, 15000);
            Console.WriteLine($"Camion - Ruedas: {camion.CantidadRuedas}, Puertas: {camion.CantidadPuertas}, Color: {camion.Color}, Marchas: {camion.CantidadMarchas}, Peso de Carga: {camion.PesoCarga}");

            Automovil automovil = new Automovil(4, 4, Colores.Rojo, 5, 5);
            Console.WriteLine($"Automovil - Ruedas: {automovil.CantidadRuedas}, Puertas: {automovil.CantidadPuertas}, Color: {automovil.Color}, Marchas: {automovil.CantidadMarchas}, Pasajeros: {automovil.CantidadPasajeros}");

            Moto moto = new Moto(2, 0, Colores.Negro, 150);
            Console.WriteLine($"Moto - Ruedas: {moto.CantidadRuedas}, Puertas: {moto.CantidadPuertas}, Color: {moto.Color}, Cilindrada: {moto.Cilindrada}");
        }
    }

    }

