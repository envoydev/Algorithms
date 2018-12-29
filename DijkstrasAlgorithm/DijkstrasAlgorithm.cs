using System;
using System.Collections.Generic;
using System.Linq;

namespace DijkstrasAlgorithm
{
    public static class DijkstrasAlgorithm
    {
        static List<string> _processed = new List<string>();
        const double _infinity = double.PositiveInfinity;

        public static void Search(IDictionary<string, Dictionary<string, double>> graph)
        {
            if (graph["start"].Any())
            {
                var costs = new Dictionary<string, double>();
                var parents = new Dictionary<string, string>();

                foreach (var combination in graph["start"])
                {
                    costs.Add(combination.Key, combination.Value);
                }
                costs.Add("fin", _infinity);

                foreach (var combination in graph["start"])
                {
                    parents.Add(combination.Key, "start");
                }
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

                _processed.Clear();

                Console.WriteLine(string.Join(", ", costs));
            }
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
