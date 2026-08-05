int Fibonacci(int n)
{
    if (n == 0 || n == 1) return n;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

int Fibonacci4 = Fibonacci(4);
int Fibonacci2 = Fibonacci(2);

Console.WriteLine(Fibonacci4);
Console.WriteLine(Fibonacci2);