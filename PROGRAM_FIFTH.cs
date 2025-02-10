// wap to find smallest part in an array in c#

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 9, 2, 7, 1 };
        int smallestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number < smallestNumber)
            {
                smallestNumber = number;
            }
        }

        Console.WriteLine($"The smallest number in the array is: {smallestNumber}");
    }
}
