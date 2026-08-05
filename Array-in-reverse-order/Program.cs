int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Array.Reverse(array);

Console.WriteLine(string.Join(", ", array));
