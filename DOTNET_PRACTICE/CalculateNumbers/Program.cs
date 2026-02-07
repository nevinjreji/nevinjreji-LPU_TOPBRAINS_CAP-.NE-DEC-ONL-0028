using System;
using System.Collections.Generic;

class Program
{
    public static List<int> NumberList = new List<int>();

    public void AddNumbers(int numbers)
    {
        NumberList.Add(numbers);
    }

    public static double GetGPAScored()
    {
        if (NumberList.Count == 0)
        {
            return -1;
        }

        double gpascoretotal = 0;

        foreach (var item in NumberList)
        {
            gpascoretotal += item * 3;
        }

        return gpascoretotal / (NumberList.Count * 3);
    }

    public char GetGradeScored(double gpa)
    {
        if (gpa == 10)
        {
            return 'S';
        }
        else if (gpa >= 9 && gpa < 10)
        {
            return 'A';
        }
        else if (gpa >= 8 && gpa < 9)
        {
            return 'B';
        }
        else if (gpa >= 7 && gpa < 8)
        {
            return 'C';
        }
        else if (gpa >= 6 && gpa < 7)
        {
            return 'D';
        }
        else if (gpa >= 5 && gpa < 6)
        {
            return 'E';
        }
        else
        {
            Console.WriteLine("Invalid GPA");
            return '\0';
        }
    }

    public static void Main(string[] args)
    {
        Program pObj = new Program();

        int numOfNumbers = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numOfNumbers; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            pObj.AddNumbers(num);
        }

        double gpa = GetGPAScored();

        if (gpa == -1)
        {
            Console.WriteLine("No Numbers Available");
        }
        else
        {
            Console.WriteLine(gpa);
            Console.WriteLine(pObj.GetGradeScored(gpa));
        }
    }
}
