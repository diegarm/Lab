using System.Collections;

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
    }
}