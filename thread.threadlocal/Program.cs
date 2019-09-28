using System;
using System.Threading;

namespace thread.threadlocal
{
    class Program
    {
        static ThreadLocal<Random> GeneradorAleatorio = new ThreadLocal<Random>(() => 
        {
            return new Random(2);
        });

        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => 
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Hilo 1: {GeneradorAleatorio.Value.Next(10)}");
                    Thread.Sleep(500);
                }
            });

            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Hilo 2: {GeneradorAleatorio.Value.Next(10)}");
                    Thread.Sleep(500);
                }
            });

            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
