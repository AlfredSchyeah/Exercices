using System;
using System.Linq;

int[] seq = { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

for (int i = 0; i < seq.Length; i++)
{
    int odd = 0;
    int count = 0;
    for (int j = 0; j < seq.Length; j++)
    {
        if (i == j) continue;
        if (seq[i] == seq[j])
        {
            count = count + 1;
        }
    }
    if (count % 2 == 0)
    {
        odd = seq[i];
        Console.WriteLine(odd);
        break;
    }
}


