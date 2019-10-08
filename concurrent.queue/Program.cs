using System;
using System.Collections.Concurrent;

namespace concurrent.queue
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
            queue.Enqueue("Juan");
            queue.Enqueue("Carla");

            string cadena;

            if (queue.TryPeek(out cadena)) // mira el primer valor
                Console.WriteLine("Primer valor de la cola: {0}", cadena);

            if (queue.TryDequeue(out cadena)) // desencola el primer valor
                Console.WriteLine("Primer valor de la cola: {0}", cadena);

            Console.ReadKey();
        }
    }
}
