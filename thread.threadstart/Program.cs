using System;
using System.Threading;

/// <summary>
/// ThreadStart es necesario en versiones anteriores del .NET Framework.
/// </summary>

namespace thread.threadstart
{
    class Program
    {
        static void Saludar()
        {
            Console.WriteLine("Hola desde un hilo");

            Thread.Sleep(2000);
        }

        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Saludar);

            Thread hilo = new Thread(ts);
            hilo.Start();
        }
    }
}
