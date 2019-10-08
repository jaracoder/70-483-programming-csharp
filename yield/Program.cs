using System;
using System.Collections;
using System.Collections.Generic;

namespace yield
{
    class Program
    {
        class EnumeradorObjeto : IEnumerable
        {
            private int limite;

            public EnumeradorObjeto(int limite)
            {
                this.limite = limite;
            }

            public IEnumerator<int> GetEnumerator()
            {
                for (int i = 0; i < limite; i++)
                {
                    // El uso de yield hará que se retorne cada elemento
                    // sin necesidad de obtenerlos todos
                    yield return i;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        class EjemploYield : IEnumerable
        {
            public IEnumerator<int> GetEnumerator()
            {
                yield return 1;
                yield return 2;
                yield return 3;
                yield return 4;
                yield return 5;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        static void Main(string[] args)
        {
            // Ejemplo de yield con EnumeradorObjeto
            EnumeradorObjeto enumerador = new EnumeradorObjeto(50);
            foreach (var e in enumerador)
            {
                // Se imprime el elemento y el procesador vuelve a procesar el siguiente elemento en GetEnumerator()
                Console.Write(e + " ");
            }
            Console.WriteLine();
            
            // Ejemplo de yield básico
            foreach (var e in new EjemploYield())
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
