using System;

namespace BinarySearch
{
    public static class BinarySearch
    {
        public static void Search(int number, int[] arrayOfNumbers)
        {
            Array.Sort(arrayOfNumbers);

            int low = 0;
            int high = arrayOfNumbers.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = arrayOfNumbers[mid];

                if (number == guess)
                {
                    Console.WriteLine($"Position: {mid}");
                    return;
                }

                if (number < guess)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            Console.WriteLine("Not found");
        }
    }
}
