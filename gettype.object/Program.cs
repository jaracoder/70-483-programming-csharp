using System;
using System.Reflection;

namespace reflection.gettype.@object
{
    class Program
    {
        public class Persona
        {
            public string Nombre { get; set; }
        }

        static void Main(string[] args)
        {
            Persona p = new Persona();
            Type tipo = p.GetType();

            Console.WriteLine("Tipo de persona: {0}", tipo);
            foreach (MemberInfo miembroInfo in tipo.GetMembers())
            {
                Console.WriteLine(miembroInfo);
            }

            Console.ReadKey();
        }
    }
}
