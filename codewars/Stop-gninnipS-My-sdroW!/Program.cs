using System;
using System.Linq;

string sentence = Console.ReadLine();

string[] words = sentence.Split(' ');

for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length > 4)
    {
        words[i] = new string(words[i].Reverse().ToArray());
    }
}

string result = string.Join(" ", words);

Console.WriteLine(result);