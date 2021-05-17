using System;

namespace Params_keyword
{
    class Program
    {
        static void PrintArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = { 5, 6, 7, 8, 9, 10 };
            PrintArray(myArray);
            PrintArray(5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);          //params keyword allows you to pass infinite no.
                                                                        //of arguments

        }
    }
}
