using System;

namespace exceptions.rethrowing
{
    class Program
    {

        /// <summary>
        /// Manera incorrecta de propagar una excepción
        /// </summary>
        static void PropagarExcepcion1()
        {
            try
            {
                throw new Exception("Boom");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Manera correcta de propagar una excepción
        /// </summary>
        static void PropagarExcepcion2()
        {
            try
            {
                throw new Exception("Boom");
            }
            catch (Exception ex)
            {
                throw new Exception("Algo a ido mal", ex);
            }
        }


        static void Main(string[] args)
        {
            try
            {
                PropagarExcepcion1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Propagar excepción 1: " + ex.InnerException);
            }

            try
            {
                PropagarExcepcion2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Propagar excepción 2: " + ex.InnerException);
            }

            Console.ReadKey();
        }
    }
}
