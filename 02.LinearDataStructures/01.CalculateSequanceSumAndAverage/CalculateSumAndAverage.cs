namespace _01.CalculateSequanceSumAndAverage
{
    /* Write a program that reads from the console a sequence of positive integer numbers. 
     * The sequence ends when empty line is entered. Calculate and print the sum and average of the elements of the sequence. 
     * Keep the sequence in List<int>.*/

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CalculateSumAndAverage
    {
        public static void Main()
        {
            List<int> inputNumbers = FillListOfNumbers();

            Console.WriteLine(inputNumbers.Average());
            Console.WriteLine(inputNumbers.Sum());
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
