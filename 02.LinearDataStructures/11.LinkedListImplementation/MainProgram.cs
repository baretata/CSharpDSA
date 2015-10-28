namespace _11.LinkedListImplementation
{
    using System;

    public class MainProgram
    {
        public static void Main()
        {
            LinkedList<int> testLinkedList = new LinkedList<int>();

            testLinkedList.AddFirst(5);
            testLinkedList.AddFirst(4);
            testLinkedList.AddLast(6);
            testLinkedList.AddLast(7);
            testLinkedList.RemoveFirst();
            testLinkedList.RemoveLast();

            foreach (var item in testLinkedList)
            {
                Console.WriteLine("Item value: {0}", item);
            }

            Console.WriteLine("Linked list items count: {0}", testLinkedList.Count());
        }
    }
}
