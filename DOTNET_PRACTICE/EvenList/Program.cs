using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbersList = new List<int>();

        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            numbersList.Add(Convert.ToInt32(Console.ReadLine()));
        }

        var evenNumbers = numbersList.Where(
                    num => num % 2 == 0)
                    .ToList();

        Console.WriteLine("Even numbers are:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
