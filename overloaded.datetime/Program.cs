using System;

namespace overloaded.datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1 = new DateTime(ticks: 610679008000000000);
            DateTime fecha2 = new DateTime(year: 2019, month:11, day:4);
            Console.WriteLine(fecha1);
            Console.WriteLine(fecha2);
            Console.ReadKey();
        }
    }
}
