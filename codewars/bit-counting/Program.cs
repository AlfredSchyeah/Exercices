int n = 1234;
if (n < 0)
{
    n = 0;
}
string binary = Convert.ToString(n, 2);
var result = binary.Count(x => x == '1');
Console.WriteLine(binary);
Console.WriteLine(result);