using System;
using System.Globalization;
using System.Threading;

namespace strings.comparison.cultures
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!"encyclopædia".Equals("encyclopaedia"))
                Console.WriteLine("encyclopaedia y encyclopædia no son iguales");
            else
                Console.WriteLine("encyclopaedia y encyclopædia son iguales");

            // Cambia el idioma en el hilo actual
            Console.WriteLine("Cambiando el idioma del hilo actual a en-US..");
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            // Compara las cadenas con StringComparison
            if (!"encyclopædia".Equals("encyclopaedia", StringComparison.CurrentCulture))
                Console.WriteLine("encyclopaedia y encyclopædia no son iguales");
            else
                Console.WriteLine("encyclopaedia y encyclopædia son iguales");

            // Compara las cadenas con StringComparison ignorando mayúsculas / minúsculas
            if (!"encyclopædia".Equals("ENCYCLOPAEDIA", StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine("ENCYCLOPAEDIA y encyclopædia no son iguales");
            else
                Console.WriteLine("ENCYCLOPAEDIA y encyclopædia son iguales");

            // Compara las cadenas con StringComparison ordinales ignorando mayúsculas / minúsculas
            if (!"encyclopædia".Equals("ENCYCLOPAEDIA", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("ENCYCLOPAEDIA y encyclopædia no son iguales");
            else
                Console.WriteLine("ENCYCLOPAEDIA y encyclopædia son iguales");

            Console.ReadKey();
        }
    }
}
