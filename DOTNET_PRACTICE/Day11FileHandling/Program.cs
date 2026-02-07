using System;
using Day11FileHandling;

class Program
{
    static void Main(String[] args)
    {
        DirectoryDemo dObj = new DirectoryDemo();

        // dObj.DirectoryDemoFunc("LPU"); 
        // dObj.DriveInfoFunc("D:\\");
        // dObj.PathDemoFunc();

        FileStreamDemo fsDemoObj = new FileStreamDemo();
        fsDemoObj.CreateFile(@"D:\CAPGEM\Day11FileHandling\SampleFile.txt");
        fsDemoObj.ReadFile(@"D:\CAPGEM\Day11FileHandling\SampleFile.txt");
    }
}