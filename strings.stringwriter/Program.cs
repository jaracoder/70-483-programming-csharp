using System;
using System.IO;

namespace strings.stringwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StringWriter escritor = new StringWriter())
            {
                escritor.WriteLine("Hola");
                Console.Write(escritor.ToString());
            }
            Console.ReadKey();
        }
    }
}
