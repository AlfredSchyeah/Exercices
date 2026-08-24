class Program
{
    static void Main()
    {
        Console.WriteLine(IsArmstrong(153));
        Console.WriteLine(IsArmstrong(123));
        Console.WriteLine(IsArmstrong(1634));
        Console.WriteLine(IsArmstrong(371));
    }

    static bool IsArmstrong(int value)
    {
        int length = value.ToString().Length;

        int number = 0;

        foreach (char CharDigit in value.ToString())
        {
            int digit = CharDigit - '0';
            int PowDigit = (int)Math.Pow(digit, length);
            number = number + PowDigit;
        }
        return number == value;
    }

}