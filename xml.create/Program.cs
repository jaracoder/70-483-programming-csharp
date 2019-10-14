using System;
using System.IO;
using System.Xml.Serialization;

namespace xml.create
{
    public class PistaMusica
    {
        public string Artista { get; set; }
        public string Titulo { get; set; }
        public int Longitud { get; set; }

        public PistaMusica()
        {

        }

        public override string ToString()
        {
            return Artista + " " + Titulo + " " + Longitud.ToString() + " segundos";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PistaMusica pista = new PistaMusica() { Artista = "Juanito", Titulo = "My Way", Longitud = 320 };

            XmlSerializer serializador = new XmlSerializer(typeof(PistaMusica));

            TextWriter escritor = new StringWriter();
            serializador.Serialize(textWriter: escritor, o: pista);
            escritor.Close();

            string pistaXML = escritor.ToString();
            Console.WriteLine("Pista serializada en XML:\n" + pistaXML);

            TextReader lector = new StringReader(pistaXML);
            PistaMusica aux = serializador.Deserialize(lector) as PistaMusica;
            Console.WriteLine("Pista deserializada en XML:\n" + aux);


            Console.ReadKey();
        }
    }
}
