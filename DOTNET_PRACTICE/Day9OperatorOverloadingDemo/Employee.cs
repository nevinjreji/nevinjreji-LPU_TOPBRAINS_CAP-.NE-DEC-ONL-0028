using System;

namespace Day9OperatorOverloadingDemo
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }

        // Operator Overloading
        public static Employee operator +(Employee e1, Employee e2)
        {
            Employee temp = new Employee();
            temp.Salary = e1.Salary + e2.Salary;
            return temp;
        }
    }
}
