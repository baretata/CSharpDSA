namespace _05.RemoveNegativeNumbers
{
    // Write a program that removes from given sequence all negative numbers.

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativeNumbers
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { -1, 2, -2, 1, 1, -1, -1, -3, 3 };
            List<int> positiveSequance = ExtractPositiveNumberSubsequance(numbers);
            Console.WriteLine(string.Join(", ", positiveSequance));
        }

        private static List<int> ExtractPositiveNumberSubsequance(List<int> numbers)
        {
            numbers = numbers.Where(n => n >= 0).ToList();
            return numbers;
        }
    }
}
