using System;

namespace Day4OOPDemo
{
    class Manager : Employee
    {
        public int MgrID { get; set; }
        public int Incentive { get; set; }

        public override int CalculateSalary(int sal)
        {
            int mySal = 0;
            // mySal = Basic + HRA + TA + DA - PF
            mySal = (sal + 35000 + 12000 + 4500) - 8500;
            return mySal;
        }
    }
}