using System;
using Day8Collection2;
class Program
{
    public void ArrayDemo()
    {
        // Simple Array of Primitive Types
        int[] arrNum;
        arrNum = new int[5];

        int[] arrNum1 = new int[3]{10,20,30};
        string[] cities = {"Delhi","Kolkata","Mumbai","Bengaluru","Kochi","Goa"};

        foreach(var item in cities)
        {
            System.Console.WriteLine(item);
        }

        foreach(var item in cities)
        {
            if(item.Length > 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{item}\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{item}\n");
            }
        }

        Customer[] custArray;
        custArray = new Customer[1];
        // Init the object
        custArray[0] = new Customer();

        custArray[0].ID = 101;
        custArray[0].Name = "Alok";
        // init the addr class
        custArray[0].BillingAddress = new Address();

        custArray[0].BillingAddress.FlatNum = "K-103";
        custArray[0].BillingAddress.BuildingName = "Crown Heights";
        custArray[0].BillingAddress.Street = "Banga Rd";
        custArray[0].BillingAddress.City = "Phagwara";

        custArray[0].ShippingAddress = custArray[0].BillingAddress;

        foreach (var item in custArray)
        {
            System.Console.WriteLine(item);
        }
         

    }
    static void Main(String[] args)
    {
        Program pObj = new Program();
        pObj.ArrayDemo();
    }
}