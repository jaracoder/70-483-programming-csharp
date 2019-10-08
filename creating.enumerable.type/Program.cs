using System;
using System.Collections;
using System.Collections.Generic;

namespace creating.enumerable.type
{
    class Program
    {

        class EnumeradorObjeto : IEnumerator<int>, IEnumerable
        {
            private int contador;
            private int limite;

            public EnumeradorObjeto(int limite)
            {
                contador = 0;
                this.limite = limite;
            }

            public int Current { get { return contador; } }

            object IEnumerator.Current { get { return contador; } }

            public void Dispose()
            {
               
            }

            public bool MoveNext()
            {
                if (++contador == limite)
                    return false;
                else
                    return true; 
            }

            public void Reset()
            {
                contador = 0;
            }

            public IEnumerator GetEnumerator()
            {
                return this;
            }
        }

 
        static void Main(string[] args)
        {
            EnumeradorObjeto enumerador = new EnumeradorObjeto(50);

            // Manera fácil de recorrer un enumerador
            foreach (var e in enumerador)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();

            // Resetea el enumerador
            enumerador.Reset();

            // Manera manual de recorrer un enumerador
            while (enumerador.MoveNext())
            {
                Console.Write(enumerador.Current + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
