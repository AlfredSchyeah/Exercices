using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int N;
    static List<int>[] children;
    static int[] T;

    static int SubtreeSum(int start)
    {
        bool[] visited = new bool[N];
        // Стек: (вершина, флаг постобработки)
        Stack<(int v, bool processed)> stack = new();
        int[] local = (int[])T.Clone();

        stack.Push((start, false));

        while (stack.Count > 0)
        {
            var (v, processed) = stack.Pop();

            if (processed)
            {
                foreach (int c in children[v])
                    if (visited[c])
                        local[v] += local[c];
                continue;
            }

            if (visited[v]) continue;
            visited[v] = true;

            stack.Push((v, true));
            foreach (int c in children[v])
                if (!visited[c])
                    stack.Push((c, false));
        }

        return local[start];
    }

    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        N = int.Parse(firstLine[0]);
        int R = int.Parse(firstLine[1]);

        T = Console.ReadLine().Split().Select(int.Parse).ToArray();

        children = new List<int>[N];
        for (int i = 0; i < N; i++)
            children[i] = new List<int>();

        for (int i = 0; i < R; i++)
        {
            string[] parts = Console.ReadLine().Split();
            int u = int.Parse(parts[0]) - 1;
            int v = int.Parse(parts[1]) - 1;
            children[u].Add(v);
        }

        int totalSum = T.Sum();
        int bestGain = -1;

        for (int v = 0; v < N; v++)
        {
            int gain = SubtreeSum(v);
            if (gain > bestGain)
                bestGain = gain;
        }

        Console.WriteLine(totalSum - bestGain);
    }
}