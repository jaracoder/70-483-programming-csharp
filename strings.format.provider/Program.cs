using System;
using System.Globalization;

namespace strings.format.provider
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 255.55;

            CultureInfo proveedorEN = new CultureInfo("en-US");
            Console.WriteLine("Mi saldo en América es de {0}", saldo.ToString("C", proveedorEN));

            CultureInfo proveedorUK = new CultureInfo("en-GB");
            Console.WriteLine("Mi saldo en Londres es de {0}", saldo.ToString("C", proveedorUK));

            CultureInfo proveedorES = new CultureInfo("es-ES");
            Console.WriteLine("Mi saldo en España es de {0}", saldo.ToString("C", proveedorES));

            Console.ReadKey();
        }
    }
}
