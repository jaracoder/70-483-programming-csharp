using System;
using System.Diagnostics;

namespace conditional.attribute
{
    class Program
    {
        [Conditional("VERBOSE"), Conditional("TERSE")]
        static void reportHeader()
        {
            Console.WriteLine("Es la cabecera del informe");
        }

        [Conditional("VERBOSE")]
        static void verboseReport()
        {
            Console.WriteLine("Es la salida del informe verbose");
        }

        [Conditional("TERSE")]
        static void terseReport()
        {
            Console.WriteLine("Es la salida del informe terse");
        }


        static void Main(string[] args)
        {
            reportHeader();
            verboseReport();
            terseReport();
            Console.ReadKey();
        }
    }
}
