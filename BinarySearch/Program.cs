using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Enumerable.Range(1, 100).ToArray();
            var number = -1;

            BinarySearch(number, array);

            Console.ReadLine();
        }

        static void BinarySearch(int number, int[] arrayOfNumbers)
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
