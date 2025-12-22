using System;

namespace Day4Assignment;
class Program
{
    public static void Main(String[] args)
    {
        int empId;
        string empName;
        int age;
        int depChocie;
        double basSal;
        string role = "";
        int depRole;
        double finalSalary = 0;
        string access;

       //Taking input
       System.Console.Write("Enter the Employee ID : ");
       empId = Int32.Parse(Console.ReadLine()!);

       System.Console.Write("Enter the Employee Name: ");
       empName = Console.ReadLine()!;

       System.Console.Write("Enter the age : ");
       age = Int32.Parse(Console.ReadLine()!);
        
        //Validation of age 
        if(age < 21)
        {
            System.Console.Write("Employee is not eligible to work");
            return;
        }

       System.Console.Write("Enter department choice -> 1.IT 2. HR 3. Finance : ");
       depChocie = Int32.Parse(Console.ReadLine()!);

       System.Console.Write("Enter your basic salary : ");
       basSal = Int32.Parse(Console.ReadLine()!);

        //switch cases to decide the role and salary
        switch (depChocie)
        {
            case 1:
                System.Console.Write("1. Developer 2. Tester : ");
                depRole = Int32.Parse(Console.ReadLine()!);
                switch (depRole)
                {
                    case 1:
                        role = "Developer";
                        finalSalary = basSal + (basSal * 30 / 100);
                        break;
                    case 2:
                        role = "Tester";
                        finalSalary = basSal + (basSal * 25 / 100);
                        break;
                    default:
                        return;
                }
                break;

            case 2:
                System.Console.Write("1. Recruiter 2. PayRoll : ");
                depRole = Int32.Parse(Console.ReadLine()!);
                switch (depRole)
                {
                    case 1:
                        role = "Recruiter";
                        finalSalary = basSal + (basSal * 20 / 100);
                        break;
                    case 2:
                        role = "PayRoll";
                        finalSalary = basSal + (basSal * 22 / 100);
                        break;
                    default:
                        return;
                }
                break;

            case 3:
                System.Console.Write("1. Accountant 2. Auditor : ");
                depRole = Int32.Parse(Console.ReadLine()!);
                switch (depRole)
                {
                    case 1:
                        role = "Accountant";
                        finalSalary = basSal + (basSal * 28 / 100);
                        break;
                    case 2:
                        role = "Auditor";
                        finalSalary = basSal + (basSal * 26 / 100);
                        break;
                    default:
                        return;
                }
                break;

            default:
                return;
        }
        
        //validation to check access level
       if(finalSalary >= 60000 && depChocie == 1)
        {
            access = "Admin Access";
        }
        else if(finalSalary >= 60000)
        {
            access = "Manager Access";
        }
        else
        {
            access = "Employee Access";
        }

        //Printing details
        System.Console.Write($"EmpID : {empId}\nEmployee Name : {empName}\nDepartment Role: {role}\nBasic Salary : {basSal}\nFinal Salary: {finalSalary}\nAccess level: {access}");
    }
}
