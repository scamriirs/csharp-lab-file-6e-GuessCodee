// WAP tp find the integere & polynomial part of a number

using System;

class Program
{
    static void Main()
    {
        double number = 12.345;
        int integerPart;
        double fractionalPart;

        GetIntegerAndFractionalParts(number, out integerPart, out fractionalPart);

        Console.WriteLine($"Original number: {number}");
        Console.WriteLine($"Integer part: {integerPart}");
        Console.WriteLine($"Fractional part: {fractionalPart}");
    }

    static void GetIntegerAndFractionalParts(double number, out int integerPart, out double fractionalPart)
    {
        integerPart = (int)number; 
        fractionalPart = number - integerPart; 
    }
}
