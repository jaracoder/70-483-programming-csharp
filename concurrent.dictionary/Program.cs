using System;
using System.Collections.Concurrent;

namespace concurrent.dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<string, int> ages = new ConcurrentDictionary<string, int>();

            if (ages.TryAdd("Juan", 21)) // Intenta añadir el valor, si ya existe devuelve false
                Console.WriteLine("Juan añadido correctamente.");

            Console.WriteLine("La edad de Juan es: {0}", ages["Juan"]); 

            if	(ages.TryUpdate("Juan",	22,	21)) // Compara el valor si son iguales lo actualiza
                Console.WriteLine("Edad actualizada correctamente.");

            Console.WriteLine("Nueva edad de Juan: {0}", ages["Juan"]); 
            Console.WriteLine("Edad de Juan actualizada a: {0}", ages.AddOrUpdate("Juan", 1, (name, age) => age = age + 1));
            Console.WriteLine("Nueva edad de Juan: {0}", ages["Juan"]);

            Console.ReadKey();
        }
    }
}
