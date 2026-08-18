int prod = int.Parse(Console.ReadLine());

int Fibonacci(int n)
{
    if (n == 0 || n == 1) return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

(int, int, bool) FindPair(int prod)
{
    int i = 0;
    for (; ; i++)
    {
        long p = (long)Fibonacci(i) * Fibonacci(i + 1);

        if (prod == p)
        {
            return (Fibonacci(i), Fibonacci(i + 1), true);
        }
        else if (prod < p)
        {
            return (Fibonacci(i), Fibonacci(i + 1), false);
        }
    }
}

var result = FindPair(prod);
Console.WriteLine(result);