using System;
using System.Threading;

namespace thread.join
{
    class Program
    {
        static void Main()
        {
            Thread hilo1 = new Thread(() =>
            {
                
                Console.WriteLine("Hilo 1 iniciado");
                Thread.Sleep(2000);
                Console.WriteLine("Hilo 1 finalizado");
            });
            hilo1.Start();
            hilo1.Join(); // Espera a que finalice el hilo 1

            Thread hilo2 = new Thread(() =>
            {

                Console.WriteLine("Hilo 2 iniciado");
                Thread.Sleep(2000);
                Console.WriteLine("Hilo 2 finalizado");
            });
            hilo2.Start();
            hilo2.Join(); // Espera a que finalice el hilo 2

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
