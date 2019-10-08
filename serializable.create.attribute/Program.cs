using System;

namespace serializable.create.attribute
{
    class Program
    {
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
        }
    }
}
