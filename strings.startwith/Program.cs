using System;

namespace strings.startwith
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "    Juan";
            string coincidencia = "Juan";

            if (texto.StartsWith(coincidencia))
            {
                Console.WriteLine($"El texto empieza con {coincidencia}.");
            }

            texto = texto.TrimStart();

            if (texto.StartsWith(coincidencia))
            {
                Console.WriteLine($"El texto empieza con {coincidencia}.");
            }

            Console.ReadKey();
        }
    }
}
