using System.Collections;
using System.Linq;

internal class Program
{
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
        //mySortedList.Add(2, "texte"); Does not allow duplicated or null keys. Keys must be unique.
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

    }
}