using System;

namespace CSharpExercises
{
    internal class Ques7
    {
        public static void Main1()
        {
            int num1, num2, sum, diff, mul, quo, rem;
            Console.Write("Input the first number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number : ");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;
            diff = num1 - num2;
            mul = num1 * num2;
            quo = num1 / num2;
            rem = num1 % num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, diff);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, mul);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, quo);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, rem);
            Console.ReadKey();
        }
    }
}
