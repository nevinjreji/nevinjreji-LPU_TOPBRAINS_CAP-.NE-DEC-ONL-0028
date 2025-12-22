// See https://aka.ms/new-console-template for more information
using System;
using Day2Console;

// static void Menu()
// {
//     System.Console.WriteLine("1. Add Student Details");
//     System.Console.WriteLine("2. Update Student Details");
//     System.Console.WriteLine("3. Drop Student Details");
// }

Console.WriteLine("Hello, World!");
Student sObj = new Student(123, "Alok", "Delhi");
sObj.DisplayDetails(sObj);

sObj = new Student(231, "Dsouza", "Bengaluru");
sObj.DisplayDetails(sObj);

string[] cities = { "Pune", "Chennai", "Bengaluru", "Kochi", "Amritsar" };
System.Console.WriteLine("\n");

// for loop
// int i = 0;
// while(i < cities.Length)
// {
//     System.Console.WriteLine(cities[i]);
//     i++;
// }

// for each loop
// foreach(var item in cities)
// {
//     System.Console.WriteLine(item);
// }


// switch
// int choice = 0;
// do
// {
//     Menu();
//     System.Console.WriteLine("Enter your choice : ");
//     choice = Int32.Parse(Console.ReadLine());

//     switch (choice)
//     {
//         case 1:
//             {
//                 break;
//             }
//         case 2:
//             {
//                 break;
//             }
//         case 3:
//             {
//                 break;
//             }
//     }
// } while (true);

// Height Assignment
Height heightObj = new Height();
int heightInCm = heightObj.GetHeight();
heightObj.DisplayHeight(heightInCm);

// Largest of Three
LargeClass.LargofThree();

// Leap Year
int year = LeapYear.GetYear();
LeapYear.CheckIfLeap(year);

BubbleSortArray arrObj = new BubbleSortArray();
int[] numbers = arrObj.ReadArray();   
arrObj.Sort(numbers);
Console.WriteLine(arrObj.GetFormattedOutput(numbers));