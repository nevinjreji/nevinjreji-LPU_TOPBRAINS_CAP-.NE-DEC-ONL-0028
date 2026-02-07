// Largest of Three: Take three integers and find the maximum using nested if.

using System;
namespace Day2Console;

public class LargeClass
{
    public static void LargofThree()
    {
        int num1, num2, num3;

        Console.WriteLine("Enter first number:");
        num1 = Int32.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter second number:");
        num2 = Int32.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter third number:");
        num3 = Int32.Parse(Console.ReadLine()!);

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine("Largest number is {0}", num1);
            }
            else
            {
                Console.WriteLine("Largest number is {0}", num3);
            }
        }
        else
        {
            if (num2 > num3)
            {
                Console.WriteLine("Largest number is {0}", num2);
            }
            else
            {
                Console.WriteLine("Largest number is {0}", num3);
            }
        }
    }
}