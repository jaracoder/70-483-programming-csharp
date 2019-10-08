using System;

namespace serializable.attributetargets
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


        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
        public class AtributoPropOField : Attribute
        {

        }


        [AtributoProgramador("jripoll.dev")]
        public class Persona
        {
            [AtributoPropOField]
            public string Nombre;
        }


        static void Main(string[] args)
        {
        }
    }
}
