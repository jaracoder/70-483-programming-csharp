using System;
using System.Linq.Expressions;

namespace lambda.expression.tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construir una expresión en árbol
            //Expression<Func<int, int>> cuadrado = n => n * n;

            // El parámetro para la expresión es un entero
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            // La operación de la expresión usando el parámetro
            BinaryExpression operacionCuadrado = Expression.Multiply(numParam, numParam);
            // Crea la expresión
            Expression<Func<int, int>> cuadrado =
                Expression.Lambda<Func<int, int>>(
                    operacionCuadrado,
                    new ParameterExpression[] { numParam });

            // Compila el arbol y hace el método ejecutable
            Func<int, int> hacerCuadrado = cuadrado.Compile();

            // Llama al delegado
            Console.WriteLine($"Cuadrado de 5: {hacerCuadrado(5)}");
            
            Console.ReadKey();
        }
    }
}
