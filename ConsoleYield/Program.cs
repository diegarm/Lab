
Console.WriteLine();

Console.WriteLine(string.Join(" ", TakeWhilePositive(new int[] { 2, 3, 4, 5, -1, 8, 9 })));
// Output: 2 3 4 5

Console.WriteLine(string.Join(" ", TakeWhilePositive(new int[] { 9, 8, 7 })));
// Output: 9 8 7

IEnumerable<int> TakeWhilePositive(IEnumerable<int> numbers)
{
    foreach (int n in numbers)
    {
        if (n > 0)
        {
            yield return n;
        }
        else
        {
            yield break;
        }
    }
}


await foreach (int n in GenerateNumbersAsync(3))
{
    Console.Write(n);
    Console.Write(" ");
}
// Output: 0 2 4 6 8

async IAsyncEnumerable<int> GenerateNumbersAsync(int count)
{
    for (int i = 0; i < count; i++)
    {
        yield return await ProduceNumberAsync(i);
    }
}

async Task<int> ProduceNumberAsync(int seed)
{
    await Task.Delay(1000);
    return 2 * seed;
}


var point = new Point(1, 2, 3);
foreach (int coordinate in point)
{
    Console.WriteLine(coordinate);
    Console.WriteLine(" ");
}
// Output: 1 2 3

var numbers = ProduceEvenNumbers(5);
Console.WriteLine("Caller: about to iterate.");
foreach (int i in numbers)
{
    Console.WriteLine($"Caller: {i}");
}

IEnumerable<int> ProduceEvenNumbers(int upto)
{
    Console.WriteLine("Iterator: start.");
    for (int i = 0; i <= upto; i += 2)
    {
        Console.WriteLine($"Iterator: about to yield {i}");
        yield return i;
        Console.WriteLine($"Iterator: yielded {i}");
    }
    Console.WriteLine("Iterator: end.");
}


public readonly record struct Point(int X, int Y, int Z)
{
    public IEnumerator<int> GetEnumerator()
    {
        yield return X;
        yield return Y;
        yield return Z;
    }
}

