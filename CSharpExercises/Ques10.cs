using System;

namespace CSharpExercises
{
    internal class Ques10
    {
        public static void Main()
        {
            int x, y, z, exp1, exp2;
            Console.Write("Enter the first number - ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number - ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number - ");
            z = int.Parse(Console.ReadLine());

            exp1 = (x + y) * z;
            exp2 = x * y + y * z;
            Console.WriteLine("Result of specified numbers {0}, {1} and {2} is (x+y).z is {3} and x.y +y.z is {4}", x, y, z, exp1, exp2);
            Console.ReadKey();

        }
    }
}
