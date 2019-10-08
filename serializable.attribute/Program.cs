using System;

namespace serializable.attribute
{
    class Program
    {
        [Serializable]
        class Persona
        {
            public string Nombre;

            public int Edad;

            [NonSerialized]
            private int posicionPantalla;

            public Persona(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
                posicionPantalla = 99;
            }
        }

        static void Main(string[] args)
        {
            if (Attribute.IsDefined(typeof(Persona), typeof(SerializableAttribute)))
            {
                Console.WriteLine("La clase persona puede ser serializada");
            }
            Console.ReadKey();
        }
    }
}
