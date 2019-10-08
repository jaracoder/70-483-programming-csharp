using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace task.monitor
{
    class Program
    {
        static long sharedTotal;

        static object sharedTotalLock = new object();

        static int[] items = Enumerable.Range(0, 50000001).ToArray();

        static void addRangeOfValues(int start, int end)
        {
            long subTotal = 0;
            while (start < end)
            {
                subTotal = subTotal + items[start];
                start++;
            }

            Monitor.Enter(sharedTotalLock); // (Monitor.TryEnter(lockObject))
            sharedTotal = sharedTotal + subTotal;
            Monitor.Exit(sharedTotalLock);
        }

        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            int rangeSize = 1000;
            int rangeStart = 0;
            while (rangeStart < items.Length)
            {
                int rangeEnd = rangeStart + rangeSize;
                if (rangeEnd > items.Length)
                    rangeEnd = items.Length;

                int rs = rangeStart;
                int re = rangeEnd;
                tasks.Add(Task.Run(() => addRangeOfValues(rs, re)));
                rangeStart = rangeEnd;
            }
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine("El total es: {0}", sharedTotal);

            Console.ReadKey();
        }
    }
}
