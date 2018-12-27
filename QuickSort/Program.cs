using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 6, 10, 2, -1, 34, 0, 1, 100 };

            QuickSort.Sort(arr, 0, arr.Length - 1);

            Console.WriteLine(string.Join(", ", arr));

            Console.ReadLine();
        }
    }
}
