using System;

namespace CSharpExercises
{
    internal class Ques8
    {
        public static void Main1()
        {
            Console.Write("Enter the number : ");
            int a = int.Parse(Console.ReadLine());
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
            }
            Console.ReadKey();
        }
    }
}
