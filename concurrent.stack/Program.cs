using System;
using System.Collections.Concurrent;

namespace concurrent.stack
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<string> stack = new ConcurrentStack<string>();
            stack.Push("Juan");
            stack.Push("Carla");

            string cadena;

            if (stack.TryPeek(out cadena)) // mira el primer valor
                Console.WriteLine("El primer valor de la pila es {0}", cadena);

            if (stack.TryPop(out cadena)) // mira el primer valor y lo quita
                Console.WriteLine("El primer valor de la pila es {0}", cadena);

            Console.ReadKey();
        }
    }
}
