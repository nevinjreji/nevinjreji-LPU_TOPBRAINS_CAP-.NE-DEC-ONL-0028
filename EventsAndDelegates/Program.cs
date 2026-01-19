using System;

class Program
{
    public void fun()
    {
        System.Console.WriteLine("Function Body");
    }

    //UNICAST DELEGATES
    public delegate void mydelegate();

    public static void Main()
    {
        Program pObj = new Program();
        mydelegate mydelObj = new mydelegate(pObj.fun);

        mydelObj();
    }
}