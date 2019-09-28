using System;
using System.Threading;

namespace thread.context.information
{
    class Program
    {
        static void MostrarHilo(Thread t)
        {
            Console.WriteLine($"Nombre: {t.Name}");
            Console.WriteLine($"Cultura: {t.CurrentCulture}");
            Console.WriteLine($"Prioridad: {t.Priority}");
            Console.WriteLine($"Contexto: {t.ExecutionContext}");
            Console.WriteLine($"¿Segundo plano?: {t.IsBackground}");
            Console.WriteLine($"¿Tiene pool?: {t.IsThreadPoolThread}");
        }

        static void Main()
        {
            Thread.CurrentThread.Name = "Método Main";
            MostrarHilo(Thread.CurrentThread);
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
