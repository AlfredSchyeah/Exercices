class Program
{
    static void Main()
    {
        Console.WriteLine(WhoLikes(new string[] { }));
        Console.WriteLine(WhoLikes(new string[] { "Alex" }));
        Console.WriteLine(WhoLikes(new string[] { "Alex", "Jacob" }));
        Console.WriteLine(WhoLikes(new string[] { "Alex", "Jacob", "Mark" }));
        Console.WriteLine(WhoLikes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
    }

    static string WhoLikes(string[] name)
    {
        int QuantityOfNames = name.Length;
        if (QuantityOfNames == 0)
        {
            return "no one likes this";
        }
        else if (QuantityOfNames == 1)
        {
            return $"{name[0]} likes this";
        }
        else if (QuantityOfNames == 2)
        {
            return $"{name[0]} and {name[1]} like this";
        }
        else if (QuantityOfNames == 3)
        {
            return $"{name[0]}, {name[1]} and {name[2]} like this";
        }
        else
        {
            return $"{name[0]}, {name[1]} and {QuantityOfNames - 2} others like this";
        }
    }
}
