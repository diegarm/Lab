﻿using System.Collections;
using System.Linq;

internal class Program
{
    public delegate void Del(string message);
    public static void DelegateMethod(string message)
    {
       Console.WriteLine(message);
    }    

    private static void Main(string[] args)
    {
        ArrayList myArrayList = new ArrayList();
        myArrayList.Add("hello"); //adding elements
        myArrayList.Add("298");
        myArrayList.Reverse(); // reversing the arrayList elements

        Console.WriteLine("Array List Reverse");
        foreach (var i in myArrayList)
            Console.WriteLine(i);


        Console.WriteLine("Hash Table");
        Hashtable myHashtable = new Hashtable();
        myHashtable[0] = "zero"; // adding elements
        myHashtable[1] = "one";

        foreach (var i in myHashtable)
            Console.WriteLine(i);


        Console.WriteLine("Queue");
        Queue myQueue = new Queue();
        myQueue.Enqueue("animal");
        myQueue.Enqueue("people");

        foreach(var i in myQueue)
            Console.WriteLine(i);


        Console.WriteLine("Stack");
        var myStack = new Stack();
        myStack.Push(false); // adding elements
        myStack.Push("dog");
        myStack.Peek(); // obtain the value of the top stack element

        foreach(var i in myStack)
            Console.WriteLine(i);


        Console.WriteLine("List Type");
        var myList = new List<string>();
        myList.Add("dog");
        myList.Add("cat");
        myList.Contains("bird");

        foreach (var item in myList)
            Console.WriteLine(item);


        Console.WriteLine("Hash Set");
        HashSet<int> myHashSet = new HashSet<int>();
        myHashSet.Add(2);

        foreach (var item in myHashSet)
            Console.WriteLine(item);


        Console.WriteLine("Sorted List");
        SortedList<int, string> mySortedList = new SortedList<int, string>();
        mySortedList.Add(2,"test");
        //mySortedList.Add(2, "txt"); Does not allow duplicated or null keys. Keys must be unique.
        foreach (var item in mySortedList)
            Console.WriteLine(item);



        Console.WriteLine("Dictionary");
        var myDictionary = new Dictionary<string, string>();
        myDictionary.Add("txt", "notepad.exe");
        myDictionary.Add("bmp", "paint.exe");
        myDictionary.Add("dib", "paint.exe");
        myDictionary.Add("rtf", "wordpad.exe");

        foreach (var item in myDictionary)
            Console.WriteLine(item);

        Console.WriteLine("Array");
        int[,] nums = new int[3, 2] { { 1, 11 }, { 2, 22 }, { 3, 33 } };
        foreach (int i in nums)
        {
            Console.WriteLine("{0}", i); // 1 11 2 22 3 33
        }

        //Outher
        Console.WriteLine("With GetEnumerator");
        var enumerator = nums.GetEnumerator();
        try
        {
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.WriteLine(item.ToString());
            }
        }
        finally
        {
            //dispose if required
        }


        Console.WriteLine("String Array");
        string[] words = { "apple", "strawberry", "grape", "peach", "banana", "groove" };
        var wordQuery = words.Where(w => w[0] == 'g');

        foreach (var word in wordQuery){
            Console.WriteLine($"{word}", word);
        }

        Console.WriteLine("IEnumerable With Yield (Defer Execution)");
        IEnumerable<int> GetNumbers()
        {
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
        }

        foreach (var item in GetNumbers())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("IEnumerable With For");
        IEnumerable<int> GetNumbersWithFor()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }

        foreach (var item in GetNumbersWithFor())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Delegate Method");
        Del handler = DelegateMethod;
        handler("hello!");

        Console.WriteLine("Using Func<X,X,X>");
        Func<int, int, bool> testEquality = (x, y) => x == y; // test for equality
        Func<int, int, int> sum = (x, y) => x + y; // test for equality
        bool test01 = testEquality(1, 2); // false
        bool test02 = testEquality(4, 4); // true
        int sum01 = sum(4, 4); // true
        Console.WriteLine(test01);
        Console.WriteLine(test02);
        Console.WriteLine(sum01);

        Console.WriteLine("Increment with Func");
        int n = 0;
        Func<int> increment = () => n++;
        increment(); //1
        increment(); //2

        Console.WriteLine(n);


        Console.WriteLine("Func with Expression (isEven)");
        Func<int, bool> isEven = x => x % 2 == 0;
        Console.WriteLine(isEven(2));
        Console.WriteLine(isEven(1));

        Console.WriteLine("IEnumerable with Where");
        int[] numbers = { 0, 30, 20, 15, 90, 85, 40, 9 };
        IEnumerable<int> res = numbers.Where((n) => n <= 10);

        foreach (var item in res)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("IEnumerable with Where Query");
        var resultQuery = from n1 in numbers
                  where n1 < 10
                  select n1;

        foreach (var item in resultQuery)
            Console.WriteLine(item);


        Console.WriteLine("Arraylist Times with Average");
        var times = new ArrayList();
        times.Add(243.53d);
        times.Add(125.32d);
        times.Add(104.23d);

        double avg = times.Cast<double>().Average();

        Console.WriteLine(avg);

        Console.WriteLine("Evens");
        int[] numbersEvens = { 0, 30, 20, 15, 90, 85, 40, 9 };
        IEnumerable<int> evens = numbersEvens.Where(i => i % 2 == 0);
        
        foreach (var item in evens)
            Console.WriteLine($"{item}");

        Console.WriteLine("Anonymous object");
        var a = new
        {
            Id = 1,
            Name = "Diego"
        };
        Console.WriteLine(a.Name);


        // Create an anonymous object with three properties: Name, Age and FavouriteFood.
        // Be careful with the capitalization of the properties!
        static Type Run(string name, int age, string favouriteFood)
        {
            var a = new { Name = name, Age = age, FavouriteFood = favouriteFood }; //FILL THIS CODE

            return a.GetType();
        }

        Console.WriteLine(Run("Diego", 25, "Pizza"));


        //Linq with Objects

        Console.WriteLine("Linq with Objects");
        var list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        var emptyList = new List<int>();

        Console.WriteLine("Count");
        Console.WriteLine(list.Count);

        Console.WriteLine("First");
        Console.WriteLine(list.First());

        Console.WriteLine("First");
        Console.WriteLine(list.First());

        Console.WriteLine("FirstOrDefault with Empty List");
        Console.WriteLine(emptyList.FirstOrDefault());

        Console.WriteLine("Last");
        Console.WriteLine(list.Last());

        Console.WriteLine("Last Or Default");
        Console.WriteLine(emptyList.LastOrDefault());

        Console.WriteLine("Single");
        Console.WriteLine(list.Single(s => s.Equals(1)));


        Console.WriteLine("Single Or Default with Empty List");
        Console.WriteLine(emptyList.SingleOrDefault(s => s.Equals(1)));


        Console.WriteLine("Element 2");
        Console.WriteLine(list.ElementAt(2));

        Console.WriteLine("Element Or Default 99");
        Console.WriteLine(list.ElementAtOrDefault(99));


        Console.WriteLine("Any - checks if any of the elements of the sequence meets the indicated condition.");
        Console.WriteLine(list.Any(n => n < 10));

        Console.WriteLine("All(): checks if all elements of the sequence meet the indicated condition");
        Console.WriteLine(list.All(n => n < 2));

        Console.WriteLine("Contains(): indicates if the sequence contains the indicated element, one or more times.");
        Console.WriteLine(list.Contains(2));



        Console.WriteLine("=========================================");
        Console.WriteLine("LINQ - GROUP BY");
        Console.WriteLine("=========================================");
        IList<Student> all = new List<Student>
        {
            new Student {First = "Diego", Last = "Bento", Score = 10},
            new Student {First = "Claire", Last = "O'Donnell", Score = 6},
            new Student {First = "Sven", Last = "Mortensen", Score = 3},
            new Student {First = "Cesar", Last = "Garcia", Score = 6},
            new Student {First = "Debra", Last = "Bento", Score = 10}
        };
        var grouped = all.GroupBy(s => s.Score);


        foreach (IGrouping<int, Student> stg in grouped)
        {
            Console.WriteLine(stg.Key);
            foreach (var s in stg)
            {
                Console.WriteLine($"{s.First} {s.Last}");
            }
        }


        var grouped2 = all.GroupBy(s => new { s.Last, s.Score });


        foreach (var stg in grouped2)
        {
            Console.WriteLine(stg.Key);
            foreach (var s in stg)
            {
                Console.WriteLine($"{s.First} {s.Last}");
            }
        }

        Console.WriteLine("=========================================");
        Console.WriteLine("LINQ - Operators (Average, Max...");
        Console.WriteLine("=========================================");

        Console.WriteLine("Average");
        Console.WriteLine(list.Average());

        Console.WriteLine("Max");
        Console.WriteLine(list.Max());

        Console.WriteLine("Min");
        Console.WriteLine(list.Min());

        Console.WriteLine("Sum");
        Console.WriteLine(list.Sum());

        Console.WriteLine("Count");
        Console.WriteLine(list.Count());


        Console.WriteLine("=========================================");
        Console.WriteLine("LINQ - List Distinct");
        Console.WriteLine("=========================================");

        var listDistinct = new List<int>() { 1,2,2,3,4,5,6,7,7,8,9,10 };

        Console.WriteLine("Without Distinct");
        foreach (var s in listDistinct) { Console.WriteLine(s); };

        var listWithDistinct = listDistinct.Distinct();

        Console.WriteLine("Distinct");
        foreach (var s in listWithDistinct) { Console.WriteLine(s); };

        Console.WriteLine("=========================================");
        Console.WriteLine("LINQ - List Except, Intersect, Union");
        Console.WriteLine("=========================================");

        var list1 = new List<int>() { 1, 2, 3, 4 };
        var list2 = new List<int>() { 4,5,6,7,8 };

        Console.WriteLine("Except");
        var listExcept = list1.Except(list2);
        
        foreach (var s in listExcept) { Console.WriteLine(s); };

        Console.WriteLine("Intersect");
        var listIntersect = list1.Intersect(list2);

        foreach (var s in listIntersect) { Console.WriteLine(s); };

        Console.WriteLine("Union");
        var listUnion = list1.Union(list2);

        foreach (var s in listUnion) { Console.WriteLine(s); };


        Console.WriteLine("=========================================");
        Console.WriteLine("LINQ - Select, Select Many");
        Console.WriteLine("=========================================");

        Console.WriteLine("Select");

        //var ressss = list.Where(n => n > 4).Select(n);


        Console.WriteLine("Select Many - String");
        List<string> strs = new List<string>()
        {
            "this is a string",
            "and a different string",
            "more strings here"
        };

        var rs = strs.SelectMany(s => s.Split(" "));
        foreach (var item in rs) { Console.WriteLine(item);  };

        Console.WriteLine("Select Many - Int");
        List<List<int>> strInts = new List<List<int>>()
        {
            new List<int>() { 1,2,3 },
            new List<int>() { 4,5,6 },
            new List<int>() { 7,8,9 }
        };

        var rsInt = strInts.SelectMany(s => s);
        foreach (var item in rsInt) { Console.WriteLine(item); };

    }




}