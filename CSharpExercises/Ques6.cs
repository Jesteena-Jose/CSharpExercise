using System;

namespace CSharpExercises
{
    internal class Ques6
    {
        public static void Main1()
        {
            int num1, num2, num3, mul;
            Console.Write("Input the first number to multiply: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            num3 = int.Parse(Console.ReadLine());
            mul = num1 * num2 * num3;
            Console.WriteLine("{0} * {1} * {2} = {3}", num1, num2, num3, mul);
            Console.ReadKey();

        }
    }
}
