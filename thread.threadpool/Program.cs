using System;
using System.Threading;

/// <summary>
/// ThreadPool: Un grupo de subprocesos. 
/// </summary>
namespace thread.threadpool
{
    class Program
    {
        static void EjecutarHilo(object num)
        {
            Console.WriteLine($"Soy el hilo {num}.");
            Thread.Sleep(2000);
        }

        static void Main()
        {
            for (int i = 0; i < 50; i++)
            {
                int num = i;
                ThreadPool.QueueUserWorkItem(estado => EjecutarHilo(num));
            }
       
            Console.ReadLine();
        }
    }
}
