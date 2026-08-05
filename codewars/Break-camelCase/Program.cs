string str = Console.ReadLine();
string result = "";

for (int i = 0; i < str.Length; i++)
{
    if (i > 0 && char.IsUpper(str[i]))
    {
        result += " ";
    }
    result += str[i];
}
Console.WriteLine(result);