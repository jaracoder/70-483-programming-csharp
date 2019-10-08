using System;

namespace @interface.printing
{
    class Program
    {
        interface IImprimible
        {
            string GetTextoImprimible(int ancho, int alto);
            string GetTitulo();
        }

        interface IMonitor
        {
            string GetTitulo();
        }

        class Informe : IImprimible, IMonitor
        {
            string IImprimible.GetTextoImprimible(int ancho, int alto)
            {
                return "Imprime texto desde la interfaz IImprimible";
            }

            string IImprimible.GetTitulo()
            {
                return "Imprime título desde la interfaz IImprimible";
            }

            string IMonitor.GetTitulo()
            {
                return "Imprime título desde la interfaz IMonitor";
            }
        }

        static void Main(string[] args)
        {
            var informe = new Informe();

            //Cuando se diseñan interfaces debe asegurarse que 
            // todos los métodos son explícitos.
            //informe.GetTitulo();

            // LLamar a métodos de la interfaz IImprimible
            IImprimible imprimible = informe;
            Console.WriteLine(imprimible.GetTextoImprimible(300, 300));
            Console.WriteLine(imprimible.GetTitulo());

            // LLamar a métodos de la interfaz IMonitor
            IMonitor monitor = informe;
            Console.WriteLine(monitor.GetTitulo());

            Console.ReadKey();
        }
    }
}
