using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear el catálogo de revistas y agregar 10 títulos
        List<string> catalogo = new List<string>
        {
            "Revista Científica", "Revista de Tecnología", "Revista de Medicina",
            "Revista de Historia", "Revista de Arte", "Revista de Literatura",
            "Revista de Cocina", "Revista de Deportes", "Revista de Política",
            "Revista de Negocios"
        };

        // Menú para interactuar con el usuario
        while (true)
        {
            Console.WriteLine("Catálogo de Revistas");
            Console.WriteLine("1. Buscar Título");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese el título de la revista a buscar: ");
                string tituloBusqueda = Console.ReadLine().ToLower(); // Convertir a minúsculas

                // Buscar el título en el catálogo (también convertimos los títulos del catálogo a minúsculas)
                bool encontrado = false;
                foreach (string titulo in catalogo)
                {
                    if (titulo.ToLower() == tituloBusqueda) // Comparación insensible a mayúsculas/minúsculas
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                {
                    Console.WriteLine("Encontrado");
                }
                else
                {
                    Console.WriteLine("No encontrado");
                }
            }
            else if (opcion == "2")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }
        }
    }
}

