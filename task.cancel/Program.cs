using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task.cancelationToken
{
    class Program
    {
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        static void Reloj()
        {
            while (!cancellationTokenSource.IsCancellationRequested)
            {
                Console.WriteLine("Reloj");
                Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            Task.Run(() => Reloj());
            Console.WriteLine("Presione cualquier tecla para detener el reloj");
            Console.ReadKey();
            cancellationTokenSource.Cancel();
            Console.WriteLine("Reloj parado");
            Console.ReadKey();
        }
    }
}
