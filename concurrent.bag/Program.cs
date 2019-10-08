using System;
using System.Collections.Concurrent;

namespace concurrent.bag
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<string> bag = new ConcurrentBag<string>();
            bag.Add("Juan");
            bag.Add("Carla");
            bag.Add("Alfonso");

            string cadena;

            if (bag.TryPeek(out cadena))
                Console.WriteLine("El objeto obtenido es {0}", cadena);

            if (bag.TryTake(out cadena))
                Console.WriteLine("El objeto quitado es {0}", cadena);

            Console.ReadKey();
        }
    }
}
