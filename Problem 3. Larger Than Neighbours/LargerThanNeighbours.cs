using System;
using System.Collections.Generic;
using System.Linq;

    class LargerThanNeighbours
    {
        static int[] arr;

        static bool CheckGreater(int idx)
        {
            bool isGreater;
            if (idx == 0)
            {
                isGreater = arr[idx] > arr[idx + 1];
            }
            else if (idx == arr.Length - 1)
            {
                isGreater = arr[idx] > arr[idx - 1];
            }
            else
            {
                isGreater = arr[idx] > arr[idx - 1] && arr[idx] > arr[idx + 1];
            }
            return isGreater;
        }
        static void Main()
        {
            string inputArray = Console.ReadLine();
            arr = inputArray.Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(CheckGreater(i));
            }
        }
    }

