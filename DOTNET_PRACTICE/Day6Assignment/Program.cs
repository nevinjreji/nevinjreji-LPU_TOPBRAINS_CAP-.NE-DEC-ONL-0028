using System;
using Day6Assignment;

class Program
{
    public static void Main(String[] args)
    {
        System.Console.Write("Enter the title : ");
        string title = Console.ReadLine()!;

        System.Console.Write("Enter the author name: ");
        string author = Console.ReadLine()!;

        System.Console.Write("Enter the number of pages: ");
        int numPages = Int32.Parse(Console.ReadLine()!);

        System.Console.Write("Enter the due date : ");
        //DateTime dueDate = DateTime.Parse(Console.ReadLine()!);
        DateTime dueDate = DateTime.ParseExact(Console.ReadLine()!, "MM/dd/yyyy",null);

        System.Console.Write("Enter the return date : ");
        //DateTime returnDate = DateTime.Parse(Console.ReadLine()!);
        DateTime returnDate = DateTime.ParseExact(Console.ReadLine()!, "MM/dd/yyyy",null);

        System.Console.Write("Enter the number of days to read: ");
        int numOfDays = Int32.Parse(Console.ReadLine()!);

        System.Console.Write("Enter the daily late feeRate: ");
        double lateFee = double.Parse(Console.ReadLine()!);

        Book bookObj = new Book(title,author,numPages,dueDate,returnDate);

        System.Console.Write($"AVERAGE PAGES READ PER DAY : {bookObj.AveragePagesReadPerDay(numOfDays)}\n");
        System.Console.WriteLine($"LATE FEE : {bookObj.CalculateLateFee(lateFee)}");

    }
}