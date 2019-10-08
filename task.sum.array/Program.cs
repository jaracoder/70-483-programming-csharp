using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task.look
{
    class Program
    {
        static object compartidaTotalBloqueo = new object();

        static long compartidaTotal;

        static int[] elementos = Enumerable.Range(0, 50000001).ToArray();

        /// <summary>
        /// Suma un rango de valores del array
        /// </summary>
        static void sumarRango(int inicio, int fin)
        {
            while (inicio < fin)
            {
                compartidaTotal = compartidaTotal + elementos[inicio];
                inicio++;
            }
        }

        /// <summary>
        /// Suma un rango de valores del array
        /// bloqueando el acceso a compartidaTotal
        /// </summary>
        static void sumarRangoConBloqueo1(int inicio, int fin)
        {
            while (inicio < fin)
            {
                lock (compartidaTotalBloqueo)
                {
                    compartidaTotal = compartidaTotal + elementos[inicio];
                    inicio++;
                }
            }
        }


        /// <summary>
        /// Suma un rango de valores del array
        /// bloqueando el acceso a compartidaTotal
        /// fuera del bucle
        /// </summary>
        static void sumarRangoConBloqueo2(int inicio, int fin)
        {
            long subTotal = 0;
            while (inicio < fin)
            {
                subTotal = subTotal + elementos[inicio];
                inicio++;
            }
            lock (compartidaTotalBloqueo)
            {
                compartidaTotal = compartidaTotal + subTotal;
            }
        }    
        static void Main(string[] args)
        {
            Sumar();
            SumarMultitarea();

            Console.ReadKey();
        }

        static void Sumar()
        {
            Console.WriteLine("Sumando el total en una tarea..");

            long total = 0;
            for (int i = 0; i < elementos.Length; i++)
                total = total + elementos[i];

            Console.WriteLine("El total es: {0}", total);
        }        static void SumarMultitarea()
        {
            Console.WriteLine("Sumando el total en multiples tareas..");

            List<Task> tareas = new List<Task>();

            int totalRango = 1000;
            int inicioRango = 0;

            while (inicioRango < elementos.Length)
            {
                int finRango = inicioRango + totalRango;
                if (finRango > elementos.Length)
                    finRango = elementos.Length;

                int rs = inicioRango;
                int re = finRango;
                tareas.Add(Task.Run(() => sumarRangoConBloqueo2(rs, re)));
                inicioRango = finRango;
            }

            Task.WaitAll(tareas.ToArray());

            Console.WriteLine("El total es: {0}", compartidaTotal);
        }
    }
}
