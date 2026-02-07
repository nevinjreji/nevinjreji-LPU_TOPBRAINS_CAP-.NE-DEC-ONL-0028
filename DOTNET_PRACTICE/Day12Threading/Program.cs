using System;
using System.Threading;

public class Program
{
    public void DoTask1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Thread 1 value is : {i}");
            Thread.Sleep(1000);
        }
    }

    public static void DoTask2()
    {
        for (int i = 11; i <= 20; i++)
        {
            Console.WriteLine($"Thread 2 value is : {i}");
            Thread.Sleep(1000);
        }
    }

    public static void Main()
    {
        Program pObj = new Program();

        Thread t1 = new Thread(new ThreadStart(pObj.DoTask1));
        Thread t2 = new Thread(new ThreadStart(Program.DoTask2));

        t1.Start();
        //t1.Join();
        t2.Start();
    }
}