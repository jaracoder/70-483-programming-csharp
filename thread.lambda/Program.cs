using System;
using System.Threading;

namespace thread.lambda
{
    class Program
    {
        static void Main()
        {
            Thread hilo = new Thread(() => 
            {
                Console.WriteLine("Hola desde un hilo");
                Thread.Sleep(2000);
            });

            hilo.Start();

            Console.WriteLine("El hilo principal del Main puede ejecutar esto antes que el nuevo hilo.");
            Console.ReadLine();
        }
    }
}
