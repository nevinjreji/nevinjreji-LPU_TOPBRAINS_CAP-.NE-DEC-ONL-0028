using System;
namespace Day2Console;

// Height Category: Accept height in cm. If < 150 (Dwarf), 150-165 (Average), 165-190 (Tall), >190 (Abnormal).

public class Height
{
    #region 
    int height;
    #endregion
    
    // Function to get height from user
    public int GetHeight()
    {
        System.Console.WriteLine("Enter the height in cm: ");
        height = Int32.Parse(Console.ReadLine()!);
        return height;
    }
    // Function to analyze the height and display the output
    public void DisplayHeight(int height)
    {
        if (height < 150)
        {
            System.Console.WriteLine("Dwarf");
        }
        else if (height >= 150 && height < 165)
        {
            System.Console.WriteLine("Average");
        }
        else if (height >= 165 && height <= 190)
        {
            System.Console.WriteLine("Tall");
        }
        else
        {
            System.Console.WriteLine("Abnormal");
        }
    }
}