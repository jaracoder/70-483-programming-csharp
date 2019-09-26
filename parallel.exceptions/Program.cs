using System;
using System.Linq;

namespace parallel.exceptions
{
    class Program
    {
        class Persona
        {
            public string Nombre { get; set; }
            public string Ciudad { get; set; }
        }

        static void Main(string[] args)
        {
            Persona[] personas = new Persona[]
            {
                new Persona { Nombre = "Juan",  Ciudad = "Alicante" },
                new Persona { Nombre = "Alan",  Ciudad = "Francia"  },
                new Persona { Nombre = "Diego", Ciudad = "Malaga"   },
                new Persona { Nombre = "Ramón", Ciudad = "Alicante" },
                new Persona { Nombre = "David", Ciudad = "Albacete" },
                new Persona { Nombre = "Ángel", Ciudad = "Paris"    },
                new Persona { Nombre = "Adara", Ciudad = "Alicante" },
                new Persona { Nombre = "Sara",  Ciudad = ""         }
            };


            try
            {
                var result = from p in personas.AsParallel()
                    where ComprobarCiudad(p.Ciudad)
                    select p;

                result.ForAll(p => Console.WriteLine(p.Nombre));
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions.Count > 1 ? $"{e.InnerExceptions.Count} personas sin ciudad." : $"{e.InnerExceptions.Count} persona sin ciudad.");
            }


            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para salir.");
            Console.Read();
        }

        static bool ComprobarCiudad(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException(nombre);

            return nombre == "Alicante";
        }
    }
}
