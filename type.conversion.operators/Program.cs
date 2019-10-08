using System;

namespace type.conversion.operators
{
    class Millas
    {
        public double Distancia { get; }
        
        public static implicit operator Kilometros(Millas t)
        {
            Console.WriteLine("Conversión implícita de millas a kms");
            return new Kilometros(t.Distancia * 1.6);
        }

        public static explicit operator int(Millas t)
        {
            Console.WriteLine("Conversión explícita de millas a entero");
            return (int)(t.Distancia + 0.5);
        }

        public Millas(double millas)
        {
            Distancia = millas;
        }
    }

    class Kilometros
    {
        public double Distancia { get; }

        public Kilometros(double km)
        {
            Distancia = km;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Millas m = new Millas(100);
            Kilometros k = m;   // conversión implicita												
            Console.WriteLine("Kilómetros: {0}", k.Distancia);
            int intMiles = (int)m; // conversión explicita
            Console.WriteLine("Millas: {0}", intMiles);
            Console.ReadKey();
        }
    }
}
