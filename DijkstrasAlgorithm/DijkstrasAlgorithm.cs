using System;
using System.Collections.Generic;

namespace DijkstrasAlgorithm
{
    public static class DijkstrasAlgorithm
    {
        readonly static List<string> _processed = new List<string>();
        const double _infinity = double.PositiveInfinity;

        public static void Search(IDictionary<string, Dictionary<string, double>> graph)
        {
            var costs = new Dictionary<string, double>
            {
                { "a", 6.0 },
                { "b", 2.0 },
                { "fin", _infinity }
            };

            var parents = new Dictionary<string, string>
            {
                { "a", "start" },
                { "b", "start" },
                { "fin", null }
            };

            var node = FindLowestCostNode(costs);
            while (node != null)
            {
                var cost = costs[node];
                var neighbors = graph[node];
                foreach (var n in neighbors.Keys)
                {
                    var new_cost = cost + neighbors[n];
                    if (costs[n] > new_cost)
                    {
                        costs[n] = new_cost;
                        parents[n] = node;
                    }
                }
                _processed.Add(node);
                node = FindLowestCostNode(costs);
            }

            Console.WriteLine(string.Join(", ", costs));
        }

        static string FindLowestCostNode(Dictionary<string, double> costs)
        {
            var lowestCost = double.PositiveInfinity;
            string lowestCostNode = null;
            foreach (var node in costs)
            {
                var cost = node.Value;
                if (cost < lowestCost && !_processed.Contains(node.Key))
                {
                    lowestCost = cost;
                    lowestCostNode = node.Key;
                }
            }
            return lowestCostNode;
        }
    }
}
