// See https://aka.ms/new-console-template for more information
using Tema9;

using System;
using System.Collections.Generic;

List<Figura> figuras = new List<Figura>(); // List to store Figura objects

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Agregar un Circulo");
    Console.WriteLine("2. Agregar un Cuadrado");
    Console.WriteLine("3. Mostrar todas las Figuras");
    Console.WriteLine("4. Mostrar todos los Circulos");
    Console.WriteLine("5. Mostrar todos los Cuadrados");
    Console.WriteLine("6. Salir");

    Console.Write("Ingrese una opción: ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Entre posicion X: ");
            int posX = int.Parse(Console.ReadLine());
            Console.Write("Entre posicion Y: ");
            int posY = int.Parse(Console.ReadLine());
            Console.Write("Entre color: ");
            string color = Console.ReadLine();
            Console.Write("Entre radio: ");
            int radio = int.Parse(Console.ReadLine());

            figuras.Add(new Circulo(posX, posY, color, radio));
            break;

        case "2":
            Console.Write("Entre posicion X: ");
            int posX1 = int.Parse(Console.ReadLine());
            Console.Write("Entre position Y: ");
            int posY1 = int.Parse(Console.ReadLine());
            Console.Write("Entre color: ");
            string color1 = Console.ReadLine();
            Console.Write("Entre lado: ");
            int lado = int.Parse(Console.ReadLine());

            figuras.Add(new Cuadrado(posX1, posY1, color1, lado));
            break;

        case "3":
            Console.WriteLine("Mostrar todas las Figuras:");
            foreach (Figura figura in figuras)
            {
                Console.Write(figura.ToString());
            }
            break;
        case "4":
            Console.WriteLine("Mostrar todos los Circulos:");
            List<Circulo> circulos = figuras.OfType<Circulo>().ToList();
            foreach (Circulo circulo in circulos)
            {
                Console.WriteLine("Circulo:");
                Console.WriteLine(circulo.ToString());
                Console.WriteLine($"Area: {circulo.Area()}");
            }
            break;
        case "5":
            Console.WriteLine("Mostrar todos los Cuadrados:");
            List<Cuadrado> cuadrados = figuras.OfType<Cuadrado>().ToList();
            foreach (Cuadrado cuadrado in cuadrados)
            {
                Console.WriteLine("Cuadrado:");
                Console.WriteLine(cuadrado.ToString());
                Console.WriteLine($"Area: {cuadrado.Area()}");
            }
            break;

        case "6":
            Console.WriteLine("Saliendo...");
            return;

        default:
            Console.WriteLine("Opción invalida");
            break;
    }

    Console.WriteLine(); 
}
