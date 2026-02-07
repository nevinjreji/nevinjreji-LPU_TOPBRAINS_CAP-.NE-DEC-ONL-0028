using System;
using System.Collections.Generic;
using KhataManagement;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> record = new Dictionary<string, int>();

        Console.Write("Enter number of items: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter item name: ");
            string item = Console.ReadLine();

            Console.Write("Enter amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            record[item] = amount;
        }               

        Khata khObj = new Khata(record);

        Console.WriteLine("Total Amount: " + khObj.GetTotal());
        Console.WriteLine("Repeated Amount Count: " + khObj.GetRepeatedAmount());
    }
}
