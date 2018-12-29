using System;
using System.Collections.Generic;

namespace DijkstrasAlgorithm
{
    class Program
    {
        readonly static Dictionary<string, Dictionary<string, double>> _graph = new Dictionary<string, Dictionary<string, double>>();

        static void Main(string[] args)
        {
            _graph.Add("start", new Dictionary<string, double>());
            _graph["start"].Add("a", 6.0);
            _graph["start"].Add("b", 2.0);

            _graph.Add("a", new Dictionary<string, double>());
            _graph["a"].Add("fin", 1.0);

            _graph.Add("b", new Dictionary<string, double>());
            _graph["b"].Add("a", 3.0);
            _graph["b"].Add("fin", 5.0);

            _graph.Add("fin", new Dictionary<string, double>());

            Console.WriteLine("Hello World!");
        }
    }
}
