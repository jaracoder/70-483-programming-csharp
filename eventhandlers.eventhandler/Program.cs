using System;

namespace eventhandlers.eventhandler
{
    class Program
    {
        class Alarma
        {
            public event EventHandler AlarmaActiva = delegate { };

            public void ActivarAlarma()
            {
                AlarmaActiva(this, EventArgs.Empty);
            }
        }

        static void Metodo1Alarma(object sender, EventArgs e)
        {
            Console.WriteLine("El método 1 está en ejecución.");
        }

        static void Metodo2Alarma(object sender, EventArgs e)
        {
            Console.WriteLine("El método 2 está en ejecución.");
        }

        static void Main(string[] args)
        {
            Alarma alarma = new Alarma();

            alarma.AlarmaActiva += Metodo1Alarma;
            alarma.AlarmaActiva += Metodo2Alarma;

            alarma.ActivarAlarma();
            Console.WriteLine("Alarma activada");

            alarma.AlarmaActiva -= Metodo1Alarma;

            alarma.ActivarAlarma();
            Console.WriteLine("Alarma activada");

            Console.ReadKey();
        }
    }
}
