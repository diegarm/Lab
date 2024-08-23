using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public static class Exercise2
    {
        // Check if a given list of strings contains some value, if it does, return the element. If it does not, return null.
        public static string Run(string[] testset, string search_value)
        {
            return testset.FirstOrDefault(a => a == search_value);
        }
    }
}
