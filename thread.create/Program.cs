using System;
using System.Threading;

namespace thread.create
{
    class Program
    {
        static void Saludar()
        {
            Console.WriteLine("Hola desde un hilo");

            Thread.Sleep(2000);
        }

        static void Main()
        {
            Thread hilo = new Thread(Saludar);
            hilo.Start();
        }
    }
}
