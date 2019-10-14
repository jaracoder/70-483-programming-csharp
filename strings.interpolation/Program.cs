using System;

namespace strings.interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Juan";
            int edad = 25;

            Console.WriteLine("Mi nombre es {0} y tengo {1, -5:D} años.", nombre, edad);
            Console.WriteLine(string.Format("Mi nombre es {0} y tengo {1, -5:D} años.", nombre, edad));

            Console.WriteLine($"Mi nombre es {nombre} y tengo {edad, -5:D} años.");
            Console.WriteLine(string.Format( $"Mi nombre es {nombre} y tengo {edad,-5:D} años."));

            Console.ReadKey();
        }
    }
}
