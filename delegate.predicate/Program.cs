using System;

namespace @delegate.predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Devuelve verdadero / falso
            Predicate<int> DivisiblePorTres = (x) => x % 3 == 0;
            Console.WriteLine(DivisiblePorTres(9) ? "El número 9 es divisible por 3." : "El número 9 no es divisible por 3.");
            
            Console.ReadKey();
        }
    }
}
