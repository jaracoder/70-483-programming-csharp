using System;

namespace @is.@as.operators
{
    class Program
    {
        class Persona
        {
            public string Nombre { get; set; }
        }

        class Alumno : Persona
        {
            public string DNI { get; set; }
        }

        static void Main(string[] args)
        {
            Persona x = new Persona();

            if (x is Persona)
            {
                Console.WriteLine("La variable p es de tipo Persona");
            }

            Console.WriteLine("Convirtiendo Persona en Alumno");
            x = x as Alumno;

            Console.ReadKey();
        }
    }
}
