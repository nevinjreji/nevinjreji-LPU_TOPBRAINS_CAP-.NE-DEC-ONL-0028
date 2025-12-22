// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Xml;
using Day4InterfaceDemo;
Console.WriteLine("Demo on Interfaces");
// IAdd m1 = new MathClass();
// IAddSub m2 = new MathClass();
// IAll m3 = new MathClass();

// System.Console.WriteLine(m1.AddMe(5,6));
// System.Console.WriteLine(m2.SubMe(5,1));


//Approach 1 
Product pObj = new Product();
pObj.ProdID = 101;
pObj.Name = "Table";
pObj.Price = 9999;

//Approach 2 -> Object Intializer
Product pObj1 = new Product(){ProdID=102,Name="ChaIr",Price=999};

//Approach 3 -> Collection Intializer
List<Product> prodList = new List<Product>()
{
    new Product(){ProdID=101,Name="Bulb",Price=100},
    new Product(){ProdID=102,Name="TubeLight",Price=350},
    new Product(){ProdID=103,Name="Bag",Price=999},
    new Product(){ProdID=104,Name="NoteBook",Price=100},
    new Product(){ProdID=105,Name="Cycle",Price=8999}
};
foreach(var item in prodList)
{
    System.Console.WriteLine($"PRODUCT ID :  {item.ProdID}\nPRODUCT NAME {item.Name}\nProduct Price : {item.Price}");
}
