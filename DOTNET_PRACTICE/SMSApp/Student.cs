using System;
namespace SMSApp
{
    public class Student
    {
        #region Fields
        int rollNo;
        string name;
        string addr;
        int phy;
        int chem;
        int maths;
        int total;
        float percent;
        #endregion
        // CLR Properties
        public int RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                rollNo = value;
            }
        }
        // Auto Implicit Property
        public string Name { get; set; }
        public string Addr { get; set; }

        // deferred property
        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
        public float Perc { get; set; }

        public int Phy
        {
            get
            {
                return phy;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    phy = value;
                }
                else
                {
                    throw new InValidMarkException("Invalid Marks");
                }
            }
        }
        public int Chem
        {
            get
            {
                return chem;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    chem = value;
                }
                else
                {
                    throw new InValidMarkException("Invalid Marks");
                }
            }
        }
        public int Maths
        {
            get
            {
                return maths;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    maths = value;
                }
                else
                {
                    throw new InValidMarkException("Invalid Marks");
                }
            }
        }
    }
    public class InValidMarkException : Exception
    {
        public InValidMarkException(string message) : base(message) { }
    }

}
