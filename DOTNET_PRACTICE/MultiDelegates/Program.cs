using System;
class Program
{
    // MULTICAST
    public void Fun1()
    {
        System.Console.WriteLine("FUNCTION 1");
    }
    public void Fun2()
    {
        System.Console.WriteLine("FUNCTION 2");
    }
    public delegate void mydelegate();

    public static void Main()
    {
        Program pObj = new Program();
        mydelegate mydelObj = new mydelegate(pObj.Fun1);
        mydelObj += pObj.Fun2;   
        mydelObj();

    }
}