using System;
using BakeMeAWish;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of cake orders to be added : ");
        int numOfOrder = Int32.Parse(Console.ReadLine()!);


        CakeOrder cakeObj = new CakeOrder();
        Console.WriteLine("Enter the cake order Details : OrderId , CakeCost");
        for (int i = 0; i < numOfOrder; i++)
        {
            string orderdetails = Console.ReadLine()!;

            string[] parts = orderdetails.Split(':');

            string cakeOrderId = parts[0];
            double cakeCost = double.Parse(parts[1]);

            cakeObj.addOrderDetails(cakeOrderId, cakeCost);
        }

        Console.WriteLine("Enter the cost to search : ");
        double cakecost = Int32.Parse(Console.ReadLine()!);

        Dictionary<string,double> returnedMap = cakeObj.findOrdersAboveSpecifiedCost(cakecost);

        foreach (var item in returnedMap)
        {
            Console.WriteLine($"ORDER ID : {item.Key}");
            Console.WriteLine($"Cake Cost : {item.Value}");
        }
    }
}