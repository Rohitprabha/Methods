using System;

namespace Pass_by_Value_vs_Reference
{
    class Program
    {
        public static void ExtraCredit(int studentGrade)            //pass by value
        {
            studentGrade += 3;
            Console.WriteLine("Student grade inside function {0}", studentGrade);
        }
        public static void CreditArray(int[] grade)                 //pass by reference
        {
            grade[0] += 3;
            Console.WriteLine("Student grade inside array before extra credit {0}", grade[0]);
        }
        static void Main(string[] args)
        {
            int studentGrade = 75;
            Console.WriteLine("Student grade before extra credit {0}", studentGrade);
            ExtraCredit(studentGrade);          //pass by value
            Console.WriteLine("Student grade after extra credit {0}", studentGrade);

            int[] grade = new int[1];
            grade[0] = 75;
            Console.WriteLine("Student grade array before extra credit {0}", grade[0]);
            CreditArray(grade);                 //pass by reference
            Console.WriteLine("Student grade array after extra credit {0}", grade[0]);
            Console.ReadKey();
        }
    }
}
