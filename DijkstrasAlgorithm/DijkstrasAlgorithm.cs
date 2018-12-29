using System;
using System.Collections.Generic;

namespace DijkstrasAlgorithm
{
    public static class DijkstrasAlgorithm
    {
        readonly static List<string> _processed = new List<string>();
        const double _infinity = double.PositiveInfinity;

        public static void Search(IDictionary<string, IDictionary<string, double>> graph)
        {
            var costs = new Dictionary<string, double>();
            costs.Add("a", 6.0);
            costs.Add("b", 2.0);
            costs.Add("fin", _infinity);

            var parents = new Dictionary<string, string>();
            parents.Add("a", "start");
            parents.Add("b", "start");
            parents.Add("fin", null);

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
