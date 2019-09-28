using System;
using System.Threading;
using System.Threading.Tasks;

namespace task.attached.childs
{
    class Program
    {
        public static void EjecutarTareaHijo(object estado)
        {
            Console.WriteLine($"Tarea hijo {estado} ejecutada");
            Thread.Sleep(2000);
            Console.WriteLine($"Tarea hijo {estado} finalizada");
        }


        static void Main(string[] args)
        {
            var tareaPadre = Task.Factory.StartNew(() => {
                Console.WriteLine("Tarea padre en ejecución");

                for (int i = 0; i < 10; i++)
                {
                    int numTarea = i;
                    Task.Factory.StartNew(
                    (x) => EjecutarTareaHijo(x), // expresión lambda 
                    numTarea, // estado del objeto
                    TaskCreationOptions.AttachedToParent);
                }   
            });
            tareaPadre.Wait(); // esperará a que todos los hijos adjuntos finalicen
            

            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para salir.");
            Console.Read();
        }
    }
}
