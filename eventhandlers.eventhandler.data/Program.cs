using System;

namespace eventhandlers.eventhandler.data
{
    class Program
    {
        class AlarmaEventArgs : EventArgs
        {
            public string Origen { get; set; }

            public AlarmaEventArgs(string origen)
            {
                Origen = origen;
            }
        }

        class Alarma
        {
            public event EventHandler<AlarmaEventArgs> AlarmaActiva = delegate { };

            public void ActivarAlarma(string origen)
            {
                AlarmaActiva(this, new AlarmaEventArgs(origen));
            }
        }

        static void Metodo1Alarma(object sender, AlarmaEventArgs args)
        {
            Console.WriteLine("El método 1 está en ejecución.");
            Console.WriteLine("El origen de la alarma es {0}.", args.Origen);
        }

        static void Metodo2Alarma(object sender, AlarmaEventArgs args)
        {
            Console.WriteLine("El método 2 está en ejecución.");
            Console.WriteLine("El origen de la alarma es {0}.", args.Origen);
        }

        static void Main(string[] args)
        {
            Alarma alarma = new Alarma();

            alarma.AlarmaActiva += Metodo1Alarma;
            alarma.AlarmaActiva += Metodo2Alarma;

            alarma.ActivarAlarma("Alicante");
            Console.WriteLine("Alarma activada");

            alarma.AlarmaActiva -= Metodo1Alarma;

            alarma.ActivarAlarma("Barcelona");
            Console.WriteLine("Alarma activada");

            Console.ReadKey();
        }
    }
}
