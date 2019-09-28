using System;
using System.Threading;

namespace thread.abort
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread hiloInfinito = new Thread(() => 
            {
                while (true)
                {
                    Console.WriteLine("Hilo en ejecución");
                    Thread.Sleep(1000);
                }
            });
            hiloInfinito.Start();

            Console.WriteLine("Presione cualquier tecla para finalizar el hilo");
            Console.ReadKey();
            hiloInfinito.Abort();
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
