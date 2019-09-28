using System;
using System.Threading;
using System.Threading.Tasks;

namespace task.@return.value
{
    class Program
    {
        public static int CalcularResultado()
        {
            Console.WriteLine("Empieza a calcular el resultado");
            Thread.Sleep(2000);
            Console.WriteLine("Acaba de calcular el resultado");

            return 13;
        }

        static void Main(string[] args)
        {
            Task<int> tarea = Task.Run(() => 
            {
                return CalcularResultado();
            });

            Console.WriteLine($"El resultado es {tarea.Result}");

            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para salir.");
            Console.Read();
        }
    }
}
