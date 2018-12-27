using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Enumerable.Range(1, 100).ToArray();
            var number = 71;

            BinarySearch.Search(number, array);

            Console.ReadLine();
        }
    }
}
