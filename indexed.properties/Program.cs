using System;

namespace indexed.properties
{
    class Program
    {
        class ArrayInt
        {
            private int[] array = new int[100];

            public int this[int i]
            {
                get
                {
                    return array[i];
                }
                set
                {
                    array[i] = value;
                }
            }
        }

        class ArrayString
        {
            private string[] array = new string[100];

            public string this[int i]
            {
                get
                {
                    return array[i];
                }
                set
                {
                    array[i] = value;
                }
            }
        }

        static void Main(string[] args)
        {
            ArrayInt x = new ArrayInt();
            x[0] = 99;
            Console.WriteLine(x[0]);

            ArrayString y = new ArrayString();
            y[0] = "Juan";
            Console.WriteLine(y[0]);

            Console.ReadKey();
        }
    }
}
