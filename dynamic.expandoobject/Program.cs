using System;
using System.Dynamic;

namespace dynamic.expandoobject
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = new ExpandoObject();
            d.Nombre = "Juan";
            d.Edad = 25;

            Console.WriteLine($"Nombre: {d.Nombre} y Edad: {d.Edad}");
            Console.ReadKey();
        }
    }
}
