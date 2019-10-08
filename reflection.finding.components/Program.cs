using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace reflection.finding.components
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
            protected decimal balance = 0;

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
        }


        public class CuentaBancariaJoven : CuentaBancaria, ICuenta
        {
            /// <summary>
            /// Sobrescribe método de Retirar de la clase padre.
            /// </summary>
            public override bool Retirar(decimal cantidad)
            {
                if (cantidad > 10)
                    return false;
                else
                    return base.Retirar(cantidad);
            }
        }


        static void Main(string[] args)
        {
            Assembly ensamblado = Assembly.GetExecutingAssembly();
            List<Type> tiposCuentas = new List<Type>();
            foreach (Type t in ensamblado.GetTypes())
            {
                if (t.IsInterface)
                    continue;

                if (typeof(ICuenta).IsAssignableFrom(t))
                    tiposCuentas.Add(t);
            }
            foreach (var t in tiposCuentas)
            {
                Console.WriteLine(t);
            }

            // Usa consulta LINQ para obtener el mismo resultado
            var tiposCuentasLINQ = from type in ensamblado.GetTypes()
                                   where typeof(ICuenta).IsAssignableFrom(type) && !type.IsInterface
                                   select type;
            foreach (var t in tiposCuentasLINQ)
            {
                Console.WriteLine(t);
            }

            Console.ReadKey();
        }
    }
}
