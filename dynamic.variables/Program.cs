using System;

namespace dynamic.variables
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = 99;
            d = d + 1;
            Console.WriteLine(d);
            d = "Juan";
            d += " y Sara";
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
