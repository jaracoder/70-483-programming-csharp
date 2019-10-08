using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task.interlook
{
    class Program
    {
        static long compartidaLocal;

        static int[] elementos = Enumerable.Range(0, 50000001).ToArray();

        static void addRangeOfValues(int start, int end)
        {
            long subTotal = 0;
            while (start < end)
            {
                subTotal = subTotal + elementos[start];
                start++;
            }

            Interlocked.Add(ref compartidaLocal, subTotal);
        }

        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            int rangeSize = 1000;
            int rangeStart = 0;
            while (rangeStart < elementos.Length)
            {
                int rangeEnd = rangeStart + rangeSize;
                if (rangeEnd > elementos.Length)
                    rangeEnd = elementos.Length;

                int rs = rangeStart;
                int re = rangeEnd;
                tasks.Add(Task.Run(() => addRangeOfValues(rs, re)));
                rangeStart = rangeEnd;
            }
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine("El total es: {0}", compartidaLocal);

            Console.ReadKey();
        }
    }
}
