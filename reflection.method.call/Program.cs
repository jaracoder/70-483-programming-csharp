using System;
using System.Reflection;

namespace reflection.method.call
{
    class Program
    {
        public class Persona
        {
            public string Nombre { get; set; }
        }

        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Type tipo = persona.GetType();
            MethodInfo setMethod = tipo.GetMethod("set_Nombre");
            setMethod.Invoke(persona, new object[] { "Juan" });
            Console.WriteLine(persona.Nombre);
            Console.ReadKey();
        }
    }
}
