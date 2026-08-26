using System.Linq;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(string.Join(", ", MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 })));
    }

    static int[] MoveZeroes(int[] arr)
    {
        int[] result = arr.Where(x => x != 0)
                            .Concat(arr.Where(x => x == 0))
                            .ToArray();
        return result;
    }
}