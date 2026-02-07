using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeMeeting;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Nevin" },
            new Employee { Id = 2, Name = "Dsouza" },
            new Employee { Id = 3, Name = "Albin" }
        };

        int searchId = 2;

        Employee emp = employees.FirstOrDefault(e => e.Id == searchId);

        if (emp != null)
        {
            Console.WriteLine($"Employee Found: Id = {emp.Id}, Name = {emp.Name}");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }
}
