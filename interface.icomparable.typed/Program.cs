using System;
using System.Collections.Generic;

namespace @interface.icomparable.typed
{
    class Program
    {
        /// <summary>
        /// La clase que implementa la interfaz debe implementar un IComparable
        /// </summary>
        public interface ICuenta : IComparable<ICuenta>
        {
            void Ingresar(decimal cantidad);
            bool Retirar(decimal cantidad);
            decimal GetSaldo();
        }

        public class CuentaBancaria : ICuenta
        {
            protected decimal balance = 0;

            public CuentaBancaria(decimal balance)
            {
                this.balance = balance;
            }

            decimal ICuenta.GetSaldo()
            {
                return balance;
            }


            void ICuenta.Ingresar(decimal cantidad)
            {
                balance += cantidad;
            }

            public virtual bool Retirar(decimal cantidad)
            {
                if (balance < cantidad)
                    return false;

                balance -= cantidad;
                return true;
            }

            public int CompareTo(ICuenta cuenta)
            {
                if (cuenta == null)
                    return 1;

                return balance.CompareTo(cuenta.GetSaldo());
            }
        }


        static void Main(string[] args)
        {
            List<ICuenta> cuentas = new List<ICuenta>();
            Random rand = new Random(1);

            // Genera cuentas bancarias al azar
            for (int i = 0; i < 20; i++)
            {
                ICuenta cuenta = new CuentaBancaria(rand.Next(0, 10000));
                cuentas.Add(cuenta);
            }

            // Ordena las cuentas bancarias
            cuentas.Sort();

            // Imprime el balance de las cuentas ordenadas
            foreach (ICuenta c in cuentas)
            {
                Console.WriteLine(c.GetSaldo());
            }

            Console.ReadKey();
        }
    }
}
