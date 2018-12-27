using System;
using System.Collections.Generic;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 10, 5, 0, 4, 1, 7 };

            var result = Operation.Sum(list);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
