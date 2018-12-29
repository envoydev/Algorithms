using System.Collections.Generic;
using System.Linq;

namespace BreadthFirstSearch
{
    public static class BreadthFirstSearch
    {
        public static string Search(string name, IDictionary<string, string[]> connections)
        {
            var queueSearch = new Queue<string>(connections[name]);
            var searched = new List<string>();

            while (queueSearch.Any())
            {
                var person = queueSearch.Dequeue();

                if (!searched.Contains(person))
                {
                    if (NeededPerson(person)) return person;

                    queueSearch = new Queue<string>(queueSearch.Concat(connections[person]));
                    searched.Add(person);
                }
            }

            return "Not Found";
        }

        static bool NeededPerson(string name)
        {
            if (name.Contains("m")) return true;

            return false;
        }
    }
}
