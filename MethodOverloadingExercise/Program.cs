using System;

namespace MethodOverloadingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 4));
            Console.WriteLine(Add(5.24m, 7.52m));
            Console.WriteLine(Add(7, 8, true));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(2, 3, false));
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isTrue)
        {
            if (isTrue)
            {
                if (x + y == 1)
                {
                    return $"{x + y} dollar";
                }
                else
                {
                    return $"{x + y} dollars";
                }
            }
            else
            {
                return (x + y).ToString();
            }
        }
    }
}
