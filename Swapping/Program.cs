using System;

class Program
{
    // swap using ref
    static void SwapRef(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    // swap using out
    static void SwapOut(int a, int b, out int x, out int y)
    {
        x = b;
        y = a;
    }

    static void Main()
    {
        Console.Write("Enter number 1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nBefore swapping (ref):");
        Console.WriteLine("n1 = " + n1 + " , n2 = " + n2);

        SwapRef(ref n1, ref n2);

        Console.WriteLine("After swapping using ref:");
        Console.WriteLine("n1 = " + n1 + " , n2 = " + n2);

        Console.WriteLine("\nBefore swapping (out):");
        Console.WriteLine("n1 = " + n1 + " , n2 = " + n2);

        int x, y;
        SwapOut(n1, n2, out x, out y);

        Console.WriteLine("After swapping using out:");
        Console.WriteLine("x = " + x + " , y = " + y);
    }
}
