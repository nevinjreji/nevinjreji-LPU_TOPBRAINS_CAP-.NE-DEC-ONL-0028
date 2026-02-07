using System;
using ProductInventoryManagement;

class Program
{
    public static void Main()
    {
        Inventory inventoryObj = new Inventory();

        while (true)
        {
            Console.WriteLine("\n--- PRODUCT INVENTORY MENU ---");
            Console.WriteLine("1. Add Products");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Get Products By Category");
            Console.WriteLine("4. Get Category Wise Product Count");
            Console.WriteLine("5. Search Product By Name");
            Console.WriteLine("6. Display All Products By Category");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");

            int choice = Int32.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                Console.Write("Enter number of products: ");
                int numOfProducts = Int32.Parse(Console.ReadLine()!);

                for (int i = 0; i < numOfProducts; i++)
                {
                    Product prodObj = new Product();

                    Console.Write("Enter product name: ");
                    prodObj.Name = Console.ReadLine()!;

                    Console.Write("Enter product category: ");
                    prodObj.Category = Console.ReadLine()!;

                    Console.Write("Enter stock: ");
                    prodObj.Stock = Int32.Parse(Console.ReadLine()!);

                    Console.Write("Enter price: ");
                    prodObj.Price = Int32.Parse(Console.ReadLine()!);

                    inventoryObj.AddProduct(prodObj);
                }

                Console.WriteLine("Products added successfully");
            }

            else if (choice == 2)
            {
                Console.Write("Enter product name to remove: ");
                string pname = Console.ReadLine()!;

                Product temp = new Product();
                temp.Name = pname;

                inventoryObj.RemoveProduct(temp);
            }

            else if (choice == 3)
            {
                Console.Write("Enter category to retrieve: ");
                string cat = Console.ReadLine()!;

                var resultlist = inventoryObj.GetProductsByCategory(cat);

                if (resultlist.Count > 0)
                {
                    foreach (var p in resultlist)
                    {
                        Console.WriteLine($"{p.Name} {p.Category} {p.Stock} {p.Price}");
                    }
                }
            }

            else if (choice == 4)
            {
                var catcount = inventoryObj.GetProductsByCategoryWithCount();

                if (catcount.Count > 0)
                {
                    foreach (var p in catcount)
                    {
                        Console.WriteLine($"{p.Item1} {p.Item2}");
                    }
                }
            }

            else if (choice == 5)
            {
                Console.Write("Enter product name to search: ");
                string productname = Console.ReadLine()!;

                var resultname = inventoryObj.SearchProductsByName(productname);

                if (resultname.Count > 0)
                {
                    foreach (var p in resultname)
                    {
                        Console.WriteLine($"{p.Name} {p.Category} {p.Stock} {p.Price}");
                    }
                }
            }

            else if (choice == 6)
            {
                var categorylist = inventoryObj.GetAllProductsByCategory();

                if (categorylist.Count > 0)
                {
                    foreach (var p in categorylist)
                    {
                        Console.WriteLine($"Category: {p.Item1}");

                        foreach (var prod in p.Item2)
                        {
                            Console.WriteLine($"   {prod.Name} {prod.Category} {prod.Stock} {prod.Price}");
                        }
                    }
                }
            }

            else if (choice == 7)
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}
