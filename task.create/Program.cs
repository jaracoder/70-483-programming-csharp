using System;
using System.Threading;
using System.Threading.Tasks;

namespace task.create
{
    class Program
    {
        static void Escribir()
        {
            Console.WriteLine("Empieza a escribir");
            Thread.Sleep(2000);
            Console.WriteLine("Acaba de escribir");
        }

        static void Main(string[] args)
        {
            // Crea tarea, inicia y espera que finalice
            Task tarea1 = new Task(() => Escribir());
            tarea1.Start();
            tarea1.Wait();


            // Crea tarea, inicia y espera que finalice
            Task tarea2 = Task.Run(() => Escribir());
            tarea2.Wait();


            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para salir.");
            Console.Read();
        }
    }
}
