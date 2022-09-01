using System;

namespace CSharpExercises
{
    internal class Ques9
    {
        public static void Main1()
        {
            int a, b, c, d;
            double avg;
            Console.Write("Enter the First number : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second number : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter the Third number : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Enter the Fourth number : ");
            d = int.Parse(Console.ReadLine());

            avg = (a + b + c + d) / 4;
            Console.WriteLine("The average of {0} , {1} , {2} , {3} is : {4}", a, b, c, d, avg);
            Console.ReadKey();

        }
    }
}
