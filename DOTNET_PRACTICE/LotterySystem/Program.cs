using System;
using LotterySystem;

class Program
{
    public static void Main(string[] args)
    {
        CustomEventArgs custObj = new CustomEventArgs();
        System.Console.Write("Enter the number of lottery tickets : ");
        custObj.Quantity = Int32.Parse(Console.ReadLine());


        //System.Console.WriteLine(Guid.NewGuid());
    }
}