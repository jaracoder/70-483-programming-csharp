using System;

namespace strings.intern
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = "Hello World Intern";
            string a = string.Intern(abc);

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
