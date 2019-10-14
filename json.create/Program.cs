using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace json.create
{
    class Program
    {
        class PistaMusica
        {
            public string Artista { get; set; }
            public string Titulo { get; set; }
            public int Longitud { get; set; }

            public PistaMusica(string artista, string titulo, int longitud)
            {
                Artista = artista;
                Titulo = titulo;
                Longitud = longitud;
            }

            public override string ToString()
            {
                return Artista + " " + Titulo + " " + Longitud.ToString() + " segundos";
            }
        }

        static void Main(string[] args)
        {
            PistaMusica pista = new PistaMusica(
                artista: "Juanito", titulo: "My Way", longitud: 240);

            // Serializa JSON del objeto PistaMusica
            string json = JsonConvert.SerializeObject(pista);
            Console.WriteLine("JSON Serializado:\n" + json);

            // Deserializa JSON del objeto PistaMusica
            PistaMusica aux = JsonConvert.DeserializeObject<PistaMusica>(json);
            Console.WriteLine("JSON Deserializado:\n" + aux);

            // Lista de pistas
            List<PistaMusica> album = new List<PistaMusica>();
            string[] nombresPistas = new[] { "My Way", "Your Way", "Their Way", "The Wrong Way" };
            foreach (string nombre in nombresPistas)
            {
                album.Add(new PistaMusica("Juanito", nombre, 230));
            }

            // Serializa lista de objetos
            string jsonArray = JsonConvert.SerializeObject(album);
            Console.WriteLine("Array JSON Serializado:\n" + jsonArray);

            // Deserializa lista de objetos
            List<PistaMusica> auxArray = JsonConvert.DeserializeObject<List<PistaMusica>>(jsonArray);
            Console.WriteLine("Array JSON Deserializado: ");
            foreach (PistaMusica p in auxArray)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}
