using System;

class Program
{
    static int[] GetTableRow(int n, int upto)
    {
        int[] row = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            row[i - 1] = n * i;
        }

        return row;
    }

    static void Main()
    {
        Console.Write("Enter the number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the limit (upto): ");
        int upto = Convert.ToInt32(Console.ReadLine());

        int[] result = GetTableRow(n, upto);

        Console.WriteLine("\nMultiplication table row:");

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);

            if (i < result.Length - 1)
                Console.Write(", ");
        }
    }
}