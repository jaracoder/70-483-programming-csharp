﻿using System;
using System.Linq;

namespace parallel.@for.all
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
                new Persona { Nombre = "Juan", Ciudad = "Alicante" },
                new Persona { Nombre = "Alan", Ciudad = "Francia" },
                new Persona { Nombre = "Diego", Ciudad = "Malaga" },
                new Persona { Nombre = "Ramón", Ciudad = "Alicante" },
                new Persona { Nombre = "David", Ciudad = "Albacete" },
                new Persona { Nombre = "Ángel", Ciudad = "Paris" },
                new Persona { Nombre = "Adara", Ciudad = "Alicante" },
                new Persona { Nombre = "Sara", Ciudad = "Amsterdam" }
            };


            // No sabemos que elemento procesará antes.
            var resultados =
                from p in personas.AsParallel()
                where p.Ciudad == "Alicante"
                select p;

            // Empezará a escribir el resultado antes de que finalice la consulta
            resultados.ForAll(p => Console.WriteLine(p.Nombre));
            Console.WriteLine();


            // No sabemos que elemento procesará antes.
            // Una vez procesados la salida se muestra ordenada como la entrada original.
            var resultadosOrdenados =
                from p in personas.AsParallel().AsOrdered()
                where p.Ciudad == "Alicante"
                select p;

            // Empezará a escribir el resultado antes de que finalice la consulta
            resultadosOrdenados.ForAll(p => Console.WriteLine(p.Nombre));
            Console.WriteLine();


            // Procesa los resultados secuencialmente 
            // en el mismo orden que el origen
            var resultadosSecuenciales =
                (from p in personas.AsParallel()
                 where p.Ciudad == "Alicante"
                 select p).AsSequential();

            // Empezará a escribir el resultado cuando finalice la consulta
            foreach (var p in resultadosSecuenciales)
                Console.WriteLine(p.Nombre);
            Console.WriteLine();


            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para salir.");
            Console.Read();
        }
    }
}
