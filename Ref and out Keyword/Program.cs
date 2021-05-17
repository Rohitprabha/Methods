using System;

namespace Ref_Keyword_and_Out_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            static void ExtraCredit(ref int studentGrade)
            {
                studentGrade += 3;
                Console.WriteLine("Student grade inside function {0}", studentGrade);
            }
            int studentGrade = 75;
            Console.WriteLine("Student grade before extra credit {0}", studentGrade);
            ExtraCredit(ref studentGrade);          //pass by value
            Console.WriteLine("Student grade after extra credit {0}", studentGrade);



            int add;
            int mult;
            AddandMul(5, 10, out add, out mult);
            Console.WriteLine(add);
            Console.WriteLine(mult);
            static void AddandMul(int a, int b, out int added, out int mult)
            {
                added = a + b;
                mult = a * b;
            }
        }
    }
}
