using System;

namespace enumerator.@string
{
    class Program
    {
        static void Main(string[] args)
        {
            var enumeradorCadena = "Hola mundo".GetEnumerator();
            while (enumeradorCadena.MoveNext())
            {
                Console.Write(enumeradorCadena.Current);
            }
            Console.ReadKey();
        }
    }
}
