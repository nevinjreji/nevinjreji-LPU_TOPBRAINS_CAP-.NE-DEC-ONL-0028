using System;

namespace Day4OOPDemo
{
    abstract class Employee
    {
        #region Properties
            public int EmployeeID { get; set; }
            public string Name { get; set; }
            public int BasicSalary { get; set; }

        #endregion

        public abstract virtual int CalculateSalary(int sal)
        {
            int mySal = 0;
            // mySal = Basic + HRA + TA + DA - PF
            mySal = (sal + 15000 + 3000 + 1500) - 2500;
            return mySal;
        }
    }
}