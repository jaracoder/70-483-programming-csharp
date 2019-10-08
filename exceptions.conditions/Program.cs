using System;

namespace exceptions.conditions
{
    class Program
    {
        class CalcException : Exception
        {
            public enum CalcErrorCodes
            {
                InvalidNumberText,
                DivideByZero
            }

            public CalcErrorCodes Error { get; set; }

            public CalcException(string message, CalcErrorCodes error) : base(message)
            {
                Error = error;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                throw new CalcException("Calc failed", CalcException.CalcErrorCodes.InvalidNumberText);
            }
            catch (CalcException ce) when (ce.Error == CalcException.CalcErrorCodes.InvalidNumberText)
            {
                Console.WriteLine("Error: {0}", ce.Error);
            }

            Console.ReadKey();
        }
    }
}
