using System;
using System.Threading;

/// <summary>
/// Mejor manera de abortar un hilo usando una variable compartida.
/// </summary>
namespace thread.abort.variable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hiloEjecucion = true;

            Thread hiloInfinito = new Thread(() =>
            {
                while (hiloEjecucion)
                {
                    Console.WriteLine("Hilo en ejecución");
                    Thread.Sleep(1000);
                }
            });
            hiloInfinito.Start();

            Console.WriteLine("Presione cualquier tecla para finalizar el hilo");
            Console.ReadKey();
            hiloEjecucion = false;
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
