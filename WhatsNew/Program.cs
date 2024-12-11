internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Start - Collection expression [.. row0, .. row1, .. row2]");

        // Create an array:
        int[] a = [1, 2, 3, 4, 5, 6, 7, 8];

        // Create a list:
        List<string> b = ["one", "two", "three"];

        // Create a jagged 2D array:
        int[][] twoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

        // Create a jagged 2D array from variables:
        int[] row0 = [1, 2, 3];
        int[] row1 = [4, 5, 6];
        int[] row2 = [7, 8, 9];
        int[][] twoDFromVariables = [row0, row1, row2];

        int[] single = [.. row0, .. row1, .. row2];

        foreach (var element in single)
        {
            Console.Write($"{element}, ");
        }

        Console.WriteLine("End - Collection expression [.. row0, .. row1, .. row2]");



        Console.WriteLine("Start - Buffer");
        var buffer = new Buffer();

        for (int i = 0; i < 15; i++)
        {
            buffer[i] = i;
        }

        Console.WriteLine("End - Buffer");


        Console.WriteLine("In Parameters");

        var inPar = 5;
        Console.WriteLine(new NormalClass().VariableNormal(ref inPar)); // prints "E" in C# 11, but "C" in C# 12
        Console.WriteLine(new NormalClass().VariableStatic(ref inPar)); // workaround: prints "E" always


        await using (var x = new C()) { }
    }
}

class NormalClass
{
    public string VariableNormal(in int i) => "C";
}
static class ClassStatic
{
    public static string VariableStatic(this NormalClass c, ref int i) => "E";
}

public class C : System.IAsyncDisposable
{
    ValueTask IAsyncDisposable.DisposeAsync() => throw null; // no longer picked

    public async ValueTask DisposeAsync()
    {
        Console.WriteLine("PICKED");
        await Task.Yield();
    }
}


[System.Runtime.CompilerServices.InlineArray(15)]
public struct Buffer
{
    private int _element0;
}

