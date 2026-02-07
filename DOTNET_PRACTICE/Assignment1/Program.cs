using System;
using Assignment1;

public class Program
{
    public static void Main()
    {
        CabDetails cab = new CabDetails();

        Console.WriteLine("Enter the booking id");
        cab.BookingID = Console.ReadLine();

        if (cab.ValidateBookingID())
        {
            Console.WriteLine("Enter the cab type");
            cab.CabType = Console.ReadLine();

            Console.WriteLine("Enter the distance in km");
            cab.Distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the waiting time in minutes");
            cab.WaitingTime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The fare amount is " + cab.CalculateFareAmount());
        }
        else
        {
            Console.WriteLine("Invalid booking id");
        }
    }
}
