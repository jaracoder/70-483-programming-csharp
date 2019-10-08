using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace eventhandlers.aggregatin.exceptions
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
                List<Exception> excepciones = new List<Exception>();

                foreach (Delegate handler in AlarmaActiva.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, new AlarmaEventArgs(origen));
                    }
                    catch (TargetInvocationException ex)
                    {
                        excepciones.Add(ex.InnerException);
                    }
                }

                if (excepciones.Count > 0)
                    throw new AggregateException(excepciones);
            }
        }

        static void Metodo1Alarma(object sender, AlarmaEventArgs args)
        {
            Console.WriteLine("El método 1 está en ejecución.");
            Console.WriteLine("El origen de la alarma es {0}.", args.Origen);

            throw new Exception("Bang");
        }

        static void Metodo2Alarma(object sender, AlarmaEventArgs args)
        {
            Console.WriteLine("El método 2 está en ejecución.");
            Console.WriteLine("El origen de la alarma es {0}.", args.Origen);

            throw new Exception("Boom");
        }

        static void Main(string[] args)
        {
            Alarma alarma = new Alarma();

            alarma.AlarmaActiva += Metodo1Alarma;
            alarma.AlarmaActiva += Metodo2Alarma;

            try
            {
                alarma.ActivarAlarma("Alicante");
                Console.WriteLine("Alarma activada");
            }
            catch (AggregateException agg)
            {
                foreach (Exception ex in agg.InnerExceptions)
                    Console.WriteLine(ex.Message);
            }
            
            alarma.AlarmaActiva -= Metodo1Alarma;

            try
            {
                alarma.ActivarAlarma("Barcelona");
                Console.WriteLine("Alarma activada");
            }
            catch (AggregateException agg)
            {
                foreach (Exception ex in agg.InnerExceptions)
                    Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
