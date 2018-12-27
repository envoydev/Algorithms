using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 3, 25, 2, 12, 7, 130, 0, 110 };

            foreach (var number in SelectionSort.Sort(numbers))
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }

    }
}
