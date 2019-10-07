using System;

namespace @interface.iaccount
{
    class Program
    {
        public interface ICuenta
        {
            void Ingresar(decimal cantidad);
            bool Retirar(decimal cantidad);
            decimal GetSaldo();
        }

        public class CuentaBancaria : ICuenta
        {
            private decimal balance = 0;

            decimal ICuenta.GetSaldo()
            {
                return balance;
            }

            void ICuenta.Ingresar(decimal cantidad)
            {
                balance += cantidad;
            }

            bool ICuenta.Retirar(decimal cantidad)
            {
                if (balance < cantidad)
                    return false;

                balance -= cantidad;
                return true;
            }
        }

        public class CuentaBancariaJoven : CuentaBancaria, ICuenta
        {
        }

        static void Main(string[] args)
        {
            // Crea cuenta bancaría y llama métodos
            ICuenta cuenta = new CuentaBancaria();
            cuenta.Ingresar(300);
            Console.WriteLine("El balance de la cuenta es de {0}", cuenta.GetSaldo());
            cuenta.Retirar(150);
            Console.WriteLine("El balance de la cuenta es de {0}", cuenta.GetSaldo());

            // Crea cuenta bancaría joven y llama métodos
            ICuenta cuentaJoven = new CuentaBancariaJoven();
            cuentaJoven.Ingresar(1200);
            Console.WriteLine("El balance de la cuenta joven es de {0}", cuentaJoven.GetSaldo());
            cuentaJoven.Retirar(50);
            Console.WriteLine("El balance de la cuenta joven es de {0}", cuentaJoven.GetSaldo());

            Console.ReadKey();
        }
    }
}
