using System;

namespace idisposable
{
    class Program
    {
        class ObjetoDisposable : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Se libera la memoria del objeto");
            }
        }

        static void Main(string[] args)
        {
            using (ObjetoDisposable obj = new ObjetoDisposable())
            {
                Console.WriteLine("Empieza el bloque del ObjetoDisposable");
            }
            Console.ReadKey();
        }
    }
}
