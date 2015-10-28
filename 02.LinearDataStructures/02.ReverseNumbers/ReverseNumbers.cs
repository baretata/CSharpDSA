namespace _02.ReverseNumbers
{
    // Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.

    using System;
    using System.Collections.Generic;

    public class ReverseNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbersInStack = new Stack<int>(n);

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbersInStack.Push(currentNumber);
            }

            Console.WriteLine(string.Join(", ", numbersInStack));
        }
    }
}
