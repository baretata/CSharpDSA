namespace _08.FindMajorantOfArray
{
    /* *The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. 
     * Write a program to find the majorant of given array (if exists). 
     * Example:{2, 2, 3, 3, 2, 3, 4, 3, 3} -> 3 */

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MajorantOfArray
    {
        public static void Main()
        {
            int[] numbers = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            int majorant = FindMajorant(numbers);

            Console.WriteLine(majorant == 0 ? "No majorant found" : "Majorant is: {0}", majorant);
        }

        private static int FindMajorant(int[] numbers)
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

            int majorantRequirement = numbers.Length / 2 + 1;
            int majorant = occurences.FirstOrDefault(n => n.Value >= majorantRequirement).Key;

            return majorant;
        }
    }
}
