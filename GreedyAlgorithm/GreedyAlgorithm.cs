using System.Collections.Generic;
using System.Linq;

namespace GreedyAlgorithm
{
    public static class GreedyAlgorithm
    {
        public static HashSet<string> Search(IDictionary<string, HashSet<string>> stations, HashSet<string> statesNeeded)
        {
            var finalStations = new HashSet<string>();

            while (statesNeeded.Any())
            {
                string bestStation = string.Empty;
                var coveredStates = new HashSet<string>();

                foreach (var station in stations)
                {
                    var covered = new HashSet<string>(statesNeeded.Intersect(station.Value));

                    if (covered.Count > coveredStates.Count)
                    {
                        bestStation = station.Key;
                        coveredStates = covered;
                    }
                }

                statesNeeded.RemoveWhere(x => coveredStates.Contains(x));
                finalStations.Add(bestStation);
            }

            return finalStations;
        }
    }
}
