using Day9OperatorOverloadingDemo;
using System;
class Program
{

    public static void Main(String[] args)
    {
        int num1 = 100;
        int num2 = 200;

        int numOfResult = num1 + num2;
        System.Console.WriteLine(numOfResult);

        Employee emp1 = new Employee();
        emp1.EmpID = 101;
        emp1.EmpName = "Alok";
        emp1.Salary = 40000;

        Employee emp2 = new Employee();
        emp2.EmpID = 102;
        emp2.EmpName = "Dsouza";
        emp2.Salary = 30000;

        Employee empObj = emp1 + emp2;
        System.Console.WriteLine($"TOTAL SALARY PAID : {empObj.Salary}");
    }
}