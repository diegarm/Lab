using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public static class Exercise3
    {
        // Check if a given list of strings contains some value just once and return it. Raise an
        // exception otherwise.
        public static string Run(string[] testset, string search_value)
        {
            try
            {
                var r = testset.Single(e => e == search_value);
                return r;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return string.Empty;
            }
            
        }
    }
}