using System;
namespace LINQConsoleApp
{  

    class Program
    {
        public static void LinqObjectDemo()
        {
            int[] numArray = [10, 20, 23, 45, 21, 8];
            string[] nameArray = ["Alok", "Rajat", "Priya", "Riya", "Dsouza"];

            // foreach (var item in numArray)
            // {
            //     if(item % 2 == 0)
            //     {
            //         System.Console.WriteLine(item);
            //     }
            // }

            // LINQ Query
            string dataToSearch = "";

            var data1 = from data in nameArray
                        where data.StartsWith("A")
                        select data;
            //  foreach (var item in data1)
            // {
            //     System.Console.WriteLine(item);
            // }

            var result = from data in numArray
                         where data % 2 == 0
                         select data;
            // foreach (var item in result)
            // {
            //     System.Console.WriteLine(item);
            // }



        }

        public static void LINQToObjectDemoOnCustomType()
        {
            List<Customer> custList = new List<Customer>()
            {
                new Customer{Id = 101 , Name = "Dsouza", City = "Kochi"},
                new Customer{Id = 102 , Name = "Nevin", City = "Bengaluru"},
                new Customer{Id = 103 , Name = "Albin", City = "Trivandrum"},
                new Customer{Id = 104 , Name = "Alok", City = "Electronic City"},
                new Customer{Id = 105 , Name = "Melvin", City = "Kochi"},
                new Customer{Id = 106 , Name = "Surya", City = "Jalandhar"},
                new Customer{Id = 107 , Name = "Shukla JI", City = "Delhi"},
                new Customer{Id = 108 , Name = "Riya", City = "Delhi"},
            };
            
            var data = new {OrderID = 101 , OrderDate = " 01/02/2026", OrderAmount = 140000};

            var result = custList.Where(cust => cust.City == "Kochi");
            var result1 = custList.Find(cust => cust.City == "Delhi");

            foreach (var item in result)
            {
                System.Console.WriteLine($"{item.Id}\t{item.Name}\t{item.City}");    
            }
            
            System.Console.WriteLine($"{result1.Id}\t{result1.Name}\t{result1.City}");
        }
        public static void LambdaLookUp()
        {
            int[] numbers = {1,2,3,4,5,6,7,9};
            
        }
        public static void Main(string[] args)
        {
            LinqObjectDemo();
            LINQToObjectDemoOnCustomType();
        }
    }
}