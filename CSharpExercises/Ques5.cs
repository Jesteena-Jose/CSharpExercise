using System;

namespace CSharpExercises
{
    internal class Ques5
    {
        public static void Main1()
        {
            Console.Write("Input the First Number : ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swapping :");
            Console.WriteLine("First Number : {0}", a);
            Console.WriteLine("Second Number : {0}", b);

            Console.ReadKey();
        }
    }
}
