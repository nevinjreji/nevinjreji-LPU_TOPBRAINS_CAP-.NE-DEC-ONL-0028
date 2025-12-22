using System;

namespace SMSApp
{
    public class StudentBL : Student
    {
        Student sObj;

        public StudentBL()
        {
            sObj = new Student();
        }

        public void AcceptStudDetails()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("Student Management System");
                Console.WriteLine("==========================");

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.Write("Enter your RollNO : ");
                sObj.RollNo = Int32.Parse(Console.ReadLine()!);

                Console.Write("Enter your Name : ");
                sObj.Name = Console.ReadLine();

                Console.Write("Enter your Address : ");
                sObj.Addr = Console.ReadLine();

                Console.Write("Enter your Phy Marks : ");
                sObj.Phy = Int32.Parse(Console.ReadLine()!);

                Console.Write("Enter your Chem Marks : ");
                sObj.Chem = Int32.Parse(Console.ReadLine()!);

                Console.Write("Enter your Maths Marks : ");
                sObj.Maths = Int32.Parse(Console.ReadLine()!);

                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (InValidMarkException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int CalcTotal()
        {
            sObj.Total = sObj.Phy + sObj.Chem + sObj.Maths;
            return sObj.Total;
        }
        public float CalcAvg()
        {
            sObj.Perc = sObj.Total / 3;
            return sObj.Perc ;
        }
        public void CalcResult(out int myTotal,out float myPerc)
        {
            myTotal=sObj.Phy+sObj.Chem+sObj.Maths;
            myPerc=myTotal/3f;
        }
    }
}
