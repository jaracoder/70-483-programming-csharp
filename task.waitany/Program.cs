using System;
using System.Threading;
using System.Threading.Tasks;

namespace task.waitany
{
    class Program
    {
        static void Escribir(int numero)
        {
            Console.WriteLine($"Empieza a escribir la tarea {numero}.");
            Thread.Sleep(2000);
            Console.WriteLine($"Acaba de escribir la tarea {numero}.");
        }

        static void Main(string[] args)
        {
            Task[] tareas = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                int numeroTarea = i + 1; // Copia de variable local con el número de tarea correcto

                tareas[i] = Task.Run(() => Escribir(numeroTarea));
            }

            Task.WaitAny(tareas); // Continua la ejecución cuando finaliza cualquiera de la tareas

            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para salir.");
            Console.Read();
        }
    }
}
