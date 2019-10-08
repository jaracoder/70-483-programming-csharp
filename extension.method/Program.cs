using System;
using myextensions.methods;

namespace extension.method
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = @"Loren ipsum lorem ipsum Loren 
                ipsum lorem ipsum Loren ipsum lorem 
                ipsumLoren ipsum lorem ipsum";

            Console.WriteLine(texto.ContadorLineas());
            Console.ReadLine();
        }
    }
}

namespace myextensions.methods
{
    public static class Extensions
    {
        public static int ContadorLineas(this string str)
        {
            return str.Split(new char[] { '\n' }, 
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}