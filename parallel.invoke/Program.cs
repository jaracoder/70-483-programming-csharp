using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parallel.invoke
{
    class Program
    {
        static void Tarea1()
        {
            Console.WriteLine("Empieza la primera tarea");
            Thread.Sleep(2000);            Console.WriteLine("Finaliza la primera tarea");
        }

        static void Tarea2()
        {
            Console.WriteLine("Empieza la segunda tarea");
            Thread.Sleep(1000);            Console.WriteLine("Finaliza la segunda tarea");
        }
        
        static void Main()
        {
            Parallel.Invoke(() => Tarea1(), () => Tarea2());
            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para salir.");
            Console.Read();
        }
    }
}
