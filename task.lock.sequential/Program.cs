using System;

namespace task.@lock.sequential
{
    class Program
    {
        static object bloqueo1 = new object();
        static object bloqueo2 = new object();

        static void Metodo1()
        {
            lock (bloqueo1)
            {
                Console.WriteLine("Método 1 empieza bloqueo 1");
                Console.WriteLine("Método 1 espera al bloqueo 2");
                lock (bloqueo2)
                {
                    Console.WriteLine("Método 1 empieza bloqueo 2");
                }
                Console.WriteLine("Método 1 se libera del bloqueo 2");
            }
            Console.WriteLine("Método 1 se libera del bloqueo 1");
        }
        static void Metodo2()
        {
            lock (bloqueo2)
            {
                Console.WriteLine("Método 2 empieza bloqueo 2");
                Console.WriteLine("Método 2 espera al bloqueo 1");
                lock (bloqueo1)
                {
                    Console.WriteLine("Método 2 empieza el bloqueo 1");
                }
                Console.WriteLine("Método 2 se libera del bloqueo 1");
            }
            Console.WriteLine("Método 2 se libera del bloqueo 2");
        }

        static void Main(string[] args)
        {
            Metodo1();
            Metodo2();
            Console.WriteLine("Methods complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
