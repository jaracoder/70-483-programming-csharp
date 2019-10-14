using System;

namespace strings.formats
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 99;
            double pi = 3.141592654;

            Console.WriteLine("{0, -10:D}{0, -10:X}{1,5:N2}", i, pi);
            Console.ReadKey();
        }
    }
}
