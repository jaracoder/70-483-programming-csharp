using System;

namespace method.overriding
{
    class Documento
    {
        public void GetFecha()
        {
            Console.WriteLine(DateTime.Now);
        }

        public virtual void Imprimir()
        {
            Console.WriteLine("Imprimiendo el documento..");
        }
    }

    class Factura : Documento
    {
        public override void Imprimir()
        {
            Console.WriteLine("Imprimiendo la factura..");
        }
    }

    class PreFactura : Factura
    {
        public override void Imprimir()
        {
            base.Imprimir();

            Console.WriteLine("Imprimiendo la prefactura..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Factura c = new Factura();
            c.GetFecha();
            c.Imprimir();

            PreFactura x = new PreFactura();
            x.Imprimir();

            Console.ReadKey();
        }
    }
}
