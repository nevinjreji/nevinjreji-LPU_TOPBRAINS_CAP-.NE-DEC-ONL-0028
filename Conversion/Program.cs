using System;

class Program
{
    public static double ConvertFeetToCentimeters(int feet)
    {
        double centimeters = feet * 30.48;
        return Math.Round(centimeters, 2, MidpointRounding.AwayFromZero);
    }

    static void Main(string[] args)
    {
        int feet = int.Parse(Console.ReadLine());
        double result = ConvertFeetToCentimeters(feet);
        Console.WriteLine(result);
    }
}
