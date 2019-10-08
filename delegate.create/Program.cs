using System;

namespace @delegate.create
{
    class Program
    {
        delegate int Operacion(int a, int b);

        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static int Restar(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            Operacion operacion = new Operacion(Sumar);
            Console.WriteLine($"2 + 2 = {operacion(2, 2)}");
            operacion = Restar;
            Console.WriteLine($"8 - 4 = {operacion(8, 4)}");

            Console.ReadKey();
        }
    }
}
