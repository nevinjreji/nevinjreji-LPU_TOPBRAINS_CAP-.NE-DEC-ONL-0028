// Leap Year Checker: Determine if a year is leap (Divisible by 400 OR (Divisible by 4 and NOT 100)).
using System;
namespace Day2Console;

public class LeapYear
{
    // Function to get year from user
    public static int GetYear()
    {
        int year;
        if ((!int.TryParse(Console.ReadLine(), out year))) ;
        {
            System.Console.WriteLine("Please enter a valid year");
        }
        return year;
    }
    // Function to check if entered year is leap year or not
    public static void CheckIfLeap(int year)
    {
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        {
            System.Console.WriteLine("The entered year {0} is leap year", year);
        }
        else
        {
            System.Console.WriteLine("The entered year {0} is not a leap year", year);
        }
    }
}