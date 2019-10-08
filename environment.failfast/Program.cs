using System;

namespace environment.failfast
{
    class Program
    {
        static void Main(string[] args)
        {
            Environment.FailFast("Finaliza proceso actual");
            Console.ReadKey(); // No ejecuta esta instrucción
        }
    }
}
