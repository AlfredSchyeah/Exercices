void Sum(params int[] numbers)
{
    int result = 0;
    foreach (var n in numbers)
    {
        result += n;
    }
    Console.WriteLine(result);
}
int[] nums = { 1, 2, 3, 4, 5 };
Sum(nums);
Sum(1, 2, 3, 4);
Sum(1, 2, 3);
Sum();


