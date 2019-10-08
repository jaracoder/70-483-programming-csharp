using System;

namespace constructor.@static
{
    class Program
    {
        public class Alien
        {
            static Alien()
            {
                Console.WriteLine("El constructor estático es llamado una sola vez.");
            }
        }

        static void Main(string[] args)
        {
            new Alien();
            new Alien();
            new Alien();
            Console.ReadKey();
        }
    }
}
