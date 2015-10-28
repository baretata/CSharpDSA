namespace _07.NumberOfOccurences
{
    /* Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
        Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        2 -> 2 times
        3 -> 4 times
        4 -> 3 times */

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindNumberOfOccurences
    {
        public static void Main()
        {
            int[] numbers = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            CountOccurenceSequance(numbers);
        }

        private static void CountOccurenceSequance(int[] numbers)
        {
            var occurences = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!occurences.ContainsKey(numbers[i]))
                {
                    occurences.Add(numbers[i], 1);
                }
                else
                {
                    occurences[numbers[i]]++;
                }
            }

            PrintArray(occurences);
        }

        private static void PrintArray(Dictionary<int,int> dictionary)
        {
            foreach (KeyValuePair<int,int> item in dictionary)
            {
                Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
