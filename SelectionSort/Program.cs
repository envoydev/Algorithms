using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 3, 25, 2, 12, 7, 130, 0, 110 };

            foreach (var number in SelectionSort(numbers))
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }

        static int[] SelectionSort(int[] array)
        {
            var sortedArray = new int[array.Length];
            var listOfItems = array.ToList();

            for (int i = 0; i < array.Length; i++)
            {
                var currentSmallest = FindSmallest(listOfItems);
                sortedArray[array.Length - 1 - i] = currentSmallest;
                listOfItems.Remove(currentSmallest);
            }

            return sortedArray;
        }

        static int FindSmallest(List<int> list)
        {
            int smallest = list[0];

            for (int i = 0; i < list.Count; i++)
            {
                if (smallest > list[i])
                {
                    smallest = list[i];
                }
            }

            return smallest;
        }
    }
}
