using System;
using System.Collections.Generic;

namespace GreedyAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var statesNeeded = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
            var stations = new Dictionary<string, HashSet<string>>
            {
                { "kone", new HashSet<string> { "id", "nv", "ut" } },
                { "ktwo", new HashSet<string> { "wa", "id", "mt" } },
                { "kthree", new HashSet<string> { "or", "nv", "ca" } },
                { "kfour", new HashSet<string> { "nv", "ut" } },
                { "kfive", new HashSet<string> { "ca", "az" } }
            };

            var result = GreedyAlgorithm.Search(stations, statesNeeded);

            Console.WriteLine(string.Join(", ", result));

            Console.ReadLine();
        }
    }
}
