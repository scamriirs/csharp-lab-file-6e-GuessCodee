// wap in c# to find square of number using pass by reference


using System;

class Program
{
    static void Main()
    {
        int number = 5;
        SquareByReference(ref number);
        Console.WriteLine($"Squared value: {number}");
    }

    static void SquareByReference(ref int num)
    {
        num = num * num;
    }
}
