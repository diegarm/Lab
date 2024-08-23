using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public static class Exercise1
    {
        // Using data from a given list of strings, create a collection of tuples that represents
        // the strings the list parameter and the number of times they appear.
        // Order them alphabetically (ASC) and return this collection.
        public static IEnumerable<Tuple<string, int>> Run(string[] testset)
        {
            var order = testset.GroupBy(e => e).Select(s => new Tuple<string,int>(s.Key.ToString(), s.Count()));
            return order.OrderBy(e => e);
        }
    }
}