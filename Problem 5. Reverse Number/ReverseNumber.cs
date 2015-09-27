using System;

    class ReverseNumber
    {
        static double reverseNumber(double num)
        {
            string number = num.ToString();
            char[] reverse = number.ToCharArray();
            Array.Reverse(reverse);
            string revNum = new string(reverse);
            double newNum = double.Parse(revNum);

            return newNum;
        }
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine(reverseNumber(number));
        }
    }

