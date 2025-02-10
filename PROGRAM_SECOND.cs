// wap in c# to find square of number using pass by value

using System;

class Program
{
    static void Main()
    {
        int number = 5;
        int result = SquareByValue(number);
        Console.WriteLine($"Original number: {number}");
        Console.WriteLine($"Squared value: {result}");
    }

    static int SquareByValue(int num)
    {
        return num * num;
    }
}
