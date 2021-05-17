using System;
namespace Recursion_Method
{
    class Program
    {
        public static int Factorial(int number)
        {
            int result;
            if (number == 1)
            {
                return 1;
            }
            else
            {
                result = number * Factorial(number - 1);
                return result;
            }
        }
        static void Main(string[] args)
        {
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(number));
        }
    }
}
