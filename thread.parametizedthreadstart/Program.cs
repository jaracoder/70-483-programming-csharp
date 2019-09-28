using System;
using System.Threading;

namespace thread.parametizedthreadstart
{
    class Program
    {
        static void Saludar(object nombre)
        {
            Console.WriteLine($"¡Hola {nombre}! Estoy en un hilo.");

            Thread.Sleep(2000);
        }

        static void Main()
        {
            ParameterizedThreadStart ps = new ParameterizedThreadStart(Saludar);

            Thread hilo = new Thread(ps);
            hilo.Start("Juan");

            Console.ReadLine();
        }
    }
}
