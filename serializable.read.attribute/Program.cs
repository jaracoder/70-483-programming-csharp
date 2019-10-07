using System;

namespace serializable.read.attribute
{
    class Program
    {
        [AttributeUsage(AttributeTargets.Class)] // Define donde se puede utilizar el atributo
        public class AtributoProgramador : Attribute
        {
            private string programador;

            public AtributoProgramador(string programador)
            {
                this.programador = programador;
            }

            public string Programador
            {
                get
                {
                    return programador;
                }
            }
        }


        [AtributoProgramador("jripoll.dev")]
        public class Persona
        {
            public string Nombre;
        }


        static void Main(string[] args)
        {
            AtributoProgramador a = (AtributoProgramador) Attribute.GetCustomAttribute(typeof(Persona), typeof(AtributoProgramador));
            Console.WriteLine("El programador encargado de la clase persona es: {0}", a.Programador);
            Console.ReadKey();
        }
    }
}
