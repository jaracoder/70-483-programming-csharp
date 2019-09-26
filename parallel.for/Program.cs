using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace parallel.@for
{
    class Program
    {
        static void ProcesarElemento(object elemento)
        {
            Console.WriteLine("Empieza a procesar el elemento {0}.", elemento);
            Thread.Sleep(100);
            Console.WriteLine("Acaba de procesar el elemento {0}.", elemento);
        }

        static void Main(string[] args)
        {
            var elementos = Enumerable.Range(0, 500).ToArray();

            Parallel.For(0, elementos.Length, i =>
            {
                ProcesarElemento(elementos[i]);
            });
      
            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para salir.");
            Console.Read();
        }
    }
}
