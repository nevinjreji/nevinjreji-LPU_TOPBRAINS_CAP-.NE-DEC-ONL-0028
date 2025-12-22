using System;
using MyRetailLogic;

class SuperShopee
{
    static void Main()
    {
        int prod1;
        int prod2;
        int numResult;

        Console.Write("Enter First Product Price : ");
        prod1 = Int32.Parse(Console.ReadLine());

        Console.Write("Enter Second Product Price : ");
        prod2 = Int32.Parse(Console.ReadLine());

        RetailLogic rlObj = new RetailLogic();

        int disc = rlObj.CalcDiscount(prod1 + prod2);
        numResult = (prod1 + prod2) - disc;

        Console.WriteLine("LPU SHOP");
        Console.WriteLine("Price of Product 1: {0} ", prod1);
        Console.WriteLine("Price of Product 2: {0}", prod2);
        Console.WriteLine("Total Price : {0}", (prod1 + prod2));
        Console.WriteLine("Discount : {0}", disc);
        Console.WriteLine("Total Payable Price After Discount: {0}", numResult);
    }
}
