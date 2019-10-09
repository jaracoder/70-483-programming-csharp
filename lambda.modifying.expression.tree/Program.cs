using System;
using System.Linq.Expressions;

namespace lambda.modifying.expression.tree
{
    class Program
    {
        public class MultiplyToAdd : ExpressionVisitor
        {
            public Expression Modificar(Expression expression)
            {
                return Visit(expression);
            }

            protected override Expression VisitBinary(BinaryExpression binaryExpression)
            {
                if (binaryExpression.NodeType == ExpressionType.Multiply)
                {
                    Expression izquierda = this.Visit(binaryExpression.Left);
                    Expression derecha = this.Visit(binaryExpression.Right);

                    return Expression.Add(izquierda, derecha);
                }

                return base.VisitBinary(binaryExpression);
            }
        }

        static void Main(string[] args)
        {
            // El parámetro para la expresión es un entero
            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");
            // La operación de la expresión usando el parámetro
            BinaryExpression operacionCuadrado = Expression.Multiply(numParam, numParam);
            // Crea la expresión
            Expression<Func<int, int>> cuadrado =
                Expression.Lambda<Func<int, int>>(
                    operacionCuadrado,
                    new ParameterExpression[] { numParam });

            
            MultiplyToAdd m = new MultiplyToAdd();
            Expression<Func<int, int>> expresionSuma = (Expression<Func<int, int>>) m.Modificar(cuadrado);

            // Compila el arbol y hace el método ejecutable
            Func<int, int> hacerSuma = expresionSuma.Compile();

            Console.WriteLine("El doble de 4 es {0}", hacerSuma(4));
            Console.ReadKey();
        }
    }
}
