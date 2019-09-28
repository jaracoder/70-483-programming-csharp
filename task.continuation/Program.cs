using System;
using System.Threading;
using System.Threading.Tasks;

namespace task.continuation
{
    class Program
    {
        public static void TareaSaludar()
        {
            Thread.Sleep(1000);
            Console.WriteLine("¡Hola!");
        }
        public static void TareaHolaMundo()
        {
            Thread.Sleep(1000);
            Console.WriteLine("¡Hola mundo!");
        }

        public static void TareaExcepcion()
        {
            Console.WriteLine("Se a producido una excepción.");
        }


        static void Main(string[] args)
        {
            Task tarea = Task.Run(() => TareaSaludar());
            tarea.ContinueWith((tareaAnterior) => TareaHolaMundo(), TaskContinuationOptions.OnlyOnRanToCompletion);
            tarea.ContinueWith((tareaAnterior) => TareaExcepcion(), TaskContinuationOptions.OnlyOnFaulted);

            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para salir.");
            Console.Read();
        }
    }
}
