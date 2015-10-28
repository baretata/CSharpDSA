namespace _03.SortListOfNumbers
{
    // Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortNumbers
    {
        public static void Main()
        {
            List<int> inputNumbers = FillListOfNumbers();

            inputNumbers.Sort();
            Console.WriteLine(string.Join(", ", inputNumbers));
        }

        private static List<int> FillListOfNumbers()
        {
            var input = Console.ReadLine();
            List<int> inputNumbers = new List<int>();

            while (!string.IsNullOrEmpty(input))
            {
                int number = int.Parse(input);
                inputNumbers.Add(number);

                input = Console.ReadLine();
            }

            return inputNumbers;
        }
    }
}
