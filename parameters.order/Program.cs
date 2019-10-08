using System;

namespace parameters.order
{
    class Program
    {
        static void PreguntarEdad(string mensaje, int min, int max)
        {
            Console.WriteLine(mensaje);
            Console.ReadLine();
            Console.WriteLine($"Pues pareces más joven");
        }

        static void Main(string[] args)
        {
            PreguntarEdad(min: 1, max: 100, mensaje: "¿Cuantos años tienes?");
            Console.ReadKey();
        }
    }
}
