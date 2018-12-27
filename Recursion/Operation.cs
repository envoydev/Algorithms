using System.Collections.Generic;
using System.Linq;

namespace Recursion
{
    public static class Operation
    {
        public static int Sum(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;

            return list.Take(1).First() + Sum(list.Skip(1));
        }

        public static int Count(IEnumerable<int> list)
        {
            if (!list.Any()) return 0;

            return 1 + Count(list.Skip(1));
        }
    }
}
