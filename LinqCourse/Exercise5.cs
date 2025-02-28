using System;
using System.Collections.Generic;
using System.Linq;

// Practical activities. This file is provided as a template, do not change the class, methods or variable names,
// just add your code in the sections marked with the "PUT YOUR CODE HERE" comment.

namespace test
{
    public static class Exercise5
    {
        // Classify the given list of strings into groups where the strings with the same length are included.
        // Order the resulting collection by the length of the strings and return it.
        //For instance: for a collection of strings: "one","two","three","four","five" you should return the following colletion:
        //{"one","two"} => strings of length three.
        //{"four", "five"} => strings of length four.
        //{"three"} => strings of length five.
        public static IEnumerable<IGrouping<int, string>> Run(string[] testset)
        {
            return testset.GroupBy(e => e.Length);
        }
    }
}