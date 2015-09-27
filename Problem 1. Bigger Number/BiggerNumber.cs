using System;

    class BiggerNumber
    {
        static int GetMax(int a, int b)
        {
            int max = Math.Max(a, b);
            return max;
        }
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int max = GetMax(a, b);
            Console.WriteLine(max);
        }
    }
