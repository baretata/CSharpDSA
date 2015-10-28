namespace _06.RemoveOddOccurences
{
    /* Write a program that removes from given sequence all numbers that occur odd number of times. 
     * Example: {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5} */

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveOddOccurence
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            List<int> oddOccurenceSequance = ExtractEvenOccurenceSubsequance(numbers);
            Console.WriteLine(string.Join(", ", oddOccurenceSequance));
        }

        private static List<int> ExtractEvenOccurenceSubsequance(List<int> numbers)
        {
            var occurences = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Count; i++)
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

            var evenOccuredNumbers = new List<int>(numbers.Where(n => occurences[n] % 2 == 0));
            return evenOccuredNumbers;
        }
    }
}
