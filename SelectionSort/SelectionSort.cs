using System.Collections.Generic;
using System.Linq;

namespace SelectionSort
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] array)
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
