using System;

namespace Day3Console
{
    internal class Program
    {
        static void SwapMe(ref int x , ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Inside Swap Func\nValue for Num1 : {0} and Num2 {1}",x,y);
        }
    
        static void Main(string[] args)
        {
            Person personObj1 = new Person();            
            //Employee emp = new Employee();

            personObj1.Display(100);
            personObj1.Display(100.25f);
            personObj1.Display("LPU");
            personObj1.Display(new Employee());


            // Casting Demo Below
            //Implicit Cast
            int x = 100;
            long z = x;
            System.Console.WriteLine(z); 

            // Explicit Cast
            //short y = short(x);

            // Boxing And Unboxing
            int num1 = 120;
            object op = num1; //Boxing - > Value to Reference
            int num2 = (int) op; //Unboxing -> Reference to Value

            int n1 = 100;
            int n2 = 200;
            Console.WriteLine("Prior Swap Func\nValue for Num1 : {0} and Num2 {1}",n1,n2);
            SwapMe(ref n1,ref n2);
            Console.WriteLine("Outside Swap Func\nValue for Num1 : {0} and Num2 {1}",n1,n2);

        }
    }
}
