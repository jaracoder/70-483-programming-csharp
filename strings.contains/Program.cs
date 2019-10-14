using System;

namespace strings.contains
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "    Esto es una prueba de Juan.";
            string coincidencia = "Juan";
            if (texto.Contains(coincidencia))
            {
                Console.WriteLine($"El texto contiene {coincidencia}.");
            }

            Console.ReadKey();
        }
    }
}
