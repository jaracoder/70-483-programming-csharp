using System;
using System.Threading;

namespace thread.lambda.parameters
{
    class Program
    {
        static void Main()
        {
            Thread hilo = new Thread((nombre) =>
            {
                Console.WriteLine($"¡Hola {nombre}! Estoy en un hilo.");
                Thread.Sleep(2000);
            });

            hilo.Start("Juan");

            Console.WriteLine("El hilo principal del Main puede ejecutar esto antes que el nuevo hilo.");
            Console.ReadLine();
        }
    }
}
