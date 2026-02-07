using System;
using Day9Work;

class Program
{
    public static void Main(String[] args)
    {
        //init Customer object first
        Customer custObj = new Customer();
        custObj.CustID = 101;
        custObj.Name = "Dsouza";

        custObj.ShippingAddr = new Address();
        custObj.ShippingAddr.FlatNo = 103;
        custObj.ShippingAddr.BuildingName = "Crown Heights";
        custObj.ShippingAddr.Street = "Phagwara";
        custObj.ShippingAddr.Locality = "Banga";
        custObj.ShippingAddr.City = "Kapurthala";


        // 1 customer many orders
        custObj.MyOrders = new List<Orders>()
        {
            new Orders(OrderID = 123, OrderDate = new DateTime(2001,12,22), Amount = 9000),
            new Orders(OrderID = 124, OrderDate = new DateTime(2001,01,22), Amount = 8000),
            new Orders(OrderID = 125, OrderDate = new DateTime(2001,02,22), Amount = 2000),
            new Orders(OrderID = 126, OrderDate = new DateTime(2001,03,22), Amount = 4000)
        };
    }
}