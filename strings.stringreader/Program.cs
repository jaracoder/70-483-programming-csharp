using System;
using System.IO;

namespace strings.stringreader
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = 
                @"Juan A. Ripoll 
25";
            using (StringReader lector = new StringReader(texto))
            {
                string nombre = lector.ReadLine();
                int edad = int.Parse(lector.ReadLine());
                Console.WriteLine($"Nombre: {nombre}. Edad: {edad}");
            }
            Console.ReadKey();
        }
    }
}
