using System;

namespace generic.types
{
    class Program
    {
        public class Pila<T> //where T: unmanaged
        {
            int indice = 0;
            T[] elementos = new T[100];


            public void Apilar(T elemento)
            {
                if (indice == elementos.Length)
                    throw new Exception("La pila está llena");

                elementos[indice] = elemento;
                indice++;
            }

            public T Desapilar()
            {
                if (indice == 0)
                    throw new Exception("La pila está vacía");

                indice--;
                return elementos[indice]; 
            }
        }

        static void Main(string[] args)
        {
            Pila<string> pilaCadenas = new Pila<string>();
            pilaCadenas.Apilar("Juan");
            pilaCadenas.Apilar("Sara");
            Console.WriteLine(pilaCadenas.Desapilar());

            Pila<int> pilaEnteros = new Pila<int>();
            pilaEnteros.Apilar(13);
            pilaEnteros.Apilar(7);
            Console.WriteLine(pilaEnteros.Desapilar());

            Console.ReadKey();
        }
    }
}
