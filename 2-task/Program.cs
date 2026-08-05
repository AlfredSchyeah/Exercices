class SpellPrimes
{
    static bool IsPrime(long n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        for (long i = 3; i * i <= n; i += 2)
            if (n % i == 0) return false;
        return true;
    }

    static List<long> PrimeNumbers()
    {
        long limit = 100000000000;
        var result = new List<long>();
        var queue = new Queue<long>();

        foreach (long d in new long[] { 2, 3, 5, 7 })
            queue.Enqueue(d);

        while (queue.Count > 0)
        {
            long n = queue.Dequeue();
            result.Add(n);

            long pow10 = 1;
            for (long tmp = n; tmp > 0; tmp /= 10)
                pow10 *= 10;

            for (long d = 1; d <= 9; d++)
            {
                long candidate = d * pow10 + n;
                if (candidate <= limit && IsPrime(candidate))
                    queue.Enqueue(candidate);
            }
        }
        return result;
    }

    static void Main()
    {
        var parts = Console.ReadLine().Split(' ');
        long n = long.Parse(parts[0]);
        long m = long.Parse(parts[1]);

        var spells = PrimeNumbers();

        int count = 0;
        foreach (var x in spells)
            if (x >= n && x <= m)
                count++;

        Console.WriteLine(count);
    }
}