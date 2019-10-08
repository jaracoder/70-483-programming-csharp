using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate.func
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> Sumar = (a, b) => a + b;
            Func<int, int, int> Restar = (a, b) => a + b;

            Console.WriteLine($"2 + 2 = {Sumar(2, 2)}");
            Console.WriteLine($"8 - 4 = {Restar(8, 4)}");

            Console.ReadKey();
        }
    }
}
