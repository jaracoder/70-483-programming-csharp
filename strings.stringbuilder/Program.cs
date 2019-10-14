using System;
using System.Text;

namespace strings.stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.Append("Hola.");
            str.Append(" ");
            str.Append("¿Que tal?");
            Console.WriteLine(str.ToString());
            Console.ReadKey();
        }
    }
}
