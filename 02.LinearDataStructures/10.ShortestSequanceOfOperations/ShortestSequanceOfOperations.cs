namespace _10.ShortestSequanceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortestSequanceOfOperations
    {
        public static void Main()
        {
            int n = 5;
            int m = 120;

            var shortestSequance = ShortestSequance(n, m);
            Console.WriteLine(string.Join(", ", shortestSequance));
        }

        public static List<int> ShortestSequance(int start, int end)
        {
            Stack<int> sequance = new Stack<int>();
            int currentNumber = end;
            sequance.Push(currentNumber);

            while (currentNumber > start)
            {
                if (currentNumber % 2 == 0 && currentNumber / 2 >= start)
                {
                    currentNumber /= 2;
                    sequance.Push(currentNumber);
                }
                else if (currentNumber % 2 == 1 && currentNumber / 2 >= start)
                {
                    currentNumber -= 1;
                    sequance.Push(currentNumber);
                }
                else if (currentNumber - 2 >= start)
                {
                    currentNumber -= 2;
                    sequance.Push(currentNumber);
                }
                else if (currentNumber - 1 >= start)
                {
                    currentNumber -= 1;
                    sequance.Push(currentNumber);
                }
            }

            return sequance.ToList();
        }
    }
}
