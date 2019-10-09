using System;
using System.Reflection;

namespace reflection.property.info
{
    class Program
    {
        class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; }
        }

        static void Main(string[] args)
        {
            Type tipo = typeof(Persona);

            foreach (PropertyInfo p in tipo.GetProperties())
            {
                Console.WriteLine("Nombre de propiedad: " + p.Name);
                if (p.CanRead)
                {
                    Console.WriteLine("Método get: " + p.GetMethod);
                }
                if (p.CanWrite)
                {
                    Console.WriteLine("Método set: " + p.SetMethod);
                }
            }

            Console.ReadKey();
        }
    }
}
