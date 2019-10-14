using System;

namespace strings.iformattable
{
    class Program
    {
        class PistaMusica : IFormattable
        {
            string Artista { get; set; }
            string Titulo { get; set; }

            public PistaMusica(string artista, string titulo)
            {
                Artista = artista;
                Titulo = titulo;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                if (string.IsNullOrWhiteSpace(format))
                    format = "G";

                switch (format)
                {
                    case "A": return Artista;
                    case "T": return Titulo;
                    case "G":
                    case "F": return Artista + " " + Titulo;
                    default:
                        throw new FormatException("El formato especificado no es válido.");
                }
            }

            public override string ToString()
            {
                return Artista + " " + Titulo;
            }
        }


        static void Main(string[] args)
        {
            PistaMusica pista = new PistaMusica("Juan A. Ripoll", "My Way");
            Console.WriteLine("Pista: {0:F}", pista);
            Console.WriteLine("Artista: {0:A}", pista);
            Console.WriteLine("Título: {0:T}", pista);
            Console.ReadKey();
        }
    }
}
