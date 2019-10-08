using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace task.blockingcollection
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<int> datos = new BlockingCollection<int>(5);

            Task.Run(() => 
            {
                for (int i = 0; i < 11; i++)
                {
                    datos.Add(i);
                    Console.WriteLine($"Dato {i} añadido correctamente.");
                }
                datos.CompleteAdding();
            });

            Console.ReadKey();
            Console.WriteLine("Leyendo la colección");

            Task.Run(() =>
            {
                while (!datos.IsCompleted)
                {
                    try
                    {
                        int v = datos.Take();
                        Console.WriteLine($"Dato {v} leido correctamente.");
                    }
                    catch (InvalidOperationException){ }
                }
            });

            Console.ReadKey();
        }
    }
}
