using System;

namespace @delegate.create.lambda
{
    class Program
    {
        delegate int Operacion(int a, int b);

        static Operacion Sumar  = (a, b) => a + b;
        static Operacion Restar = (a, b) => a - b;
        
        static void Main(string[] args)
        {
            Console.WriteLine($"2 + 2 = {Sumar(2, 2)}");
            Console.WriteLine($"8 - 4 = {Restar(8, 4)}");

            Console.ReadKey();
        }
    }
}
