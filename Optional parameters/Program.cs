using System;

namespace Optional_Parameters
{
    class Program
    {
        public static void Add(int x, int y = 1, int z = 2)
        {
            Console.WriteLine(x + y + z);
        }
        static void Main(string[] args)
        {
            Add(5);
            Add(5,z:5);
        }
    }
}
