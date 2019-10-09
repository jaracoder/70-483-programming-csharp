using System;
using System.Reflection;

namespace reflection.method.info
{
    class Program
    {
        class Calculadora
        {
            public int Sumar(int num1, int num2)
            {
                return num1 + num2;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Obtiene información de Calculadora");
            Type tipo = typeof(Calculadora);

            Console.WriteLine("Obtiene información del método sumar");
            MethodInfo metodoSumarInfo = tipo.GetMethod("Sumar");
            MethodBody metodoSumarCuerpo = metodoSumarInfo.GetMethodBody();

            Console.WriteLine("Obtiene instrucciones IL para el método sumar");
            foreach (byte b in metodoSumarCuerpo.GetILAsByteArray())
            {
                Console.Write(" {0:X}", b);
            }
            Console.WriteLine();

            Console.WriteLine("Crea instancia de Calculadora");
            Calculadora calc = new Calculadora();

            Console.WriteLine("Crea array de parámetros para el método sumar");
            object[] inputs = new object[] { 4, 2 };
            Console.WriteLine("Invoca al método sumar");
            int result = (int) metodoSumarInfo.Invoke(calc, inputs);
            Console.WriteLine("Resultado del método sumar es " + result);

            Console.WriteLine("Llamada a InvokeMember desde el Tipo al método sumar");
            result = (int)tipo.InvokeMember("Sumar", 
                BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public, 
                null, 
                calc, 
                inputs);
            Console.WriteLine("Resultado del método sumar es " + result);

            Console.ReadKey();
        }
    }
}
