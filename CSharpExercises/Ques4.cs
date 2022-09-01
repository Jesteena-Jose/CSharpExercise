using System;

namespace CSharpExercises
{
    internal class Ques4
    {
        public static void Main1()
        {
            int a = -1;
            int b = 4;
            int c = 6;
            Console.WriteLine(a + b * c);
            a = 35;
            b = 5;
            c = 7;
            Console.WriteLine((a + b) % c);
            a = 14;
            b = -4;
            c = 6;
            int d = 11;
            Console.WriteLine(a + b * c / d);
            a = 2;
            b = 15;
            c = 6;
            d = 1;
            int e = 7;
            int f = 2;
            Console.WriteLine(a + b / c * d - e % f);
            Console.ReadKey();
        }
    }
}
