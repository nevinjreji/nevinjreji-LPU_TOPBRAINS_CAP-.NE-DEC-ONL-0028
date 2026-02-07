using System;

class Program
{
    public delegate string myDelegate(string st1, string st2);
    public event myDelegate myEvent;

    public Program()
    {
        this.myEvent += Program_myevent;
    }

    private string Program_myevent(string st1, string st2)
    {
        return st1 + st2;
    }

    public string RaiseEvent(string a, string b)
    {
        return myEvent(a, b);
    }

    public static void Main()
    {
        Program obj = new Program();
        Console.WriteLine(obj.RaiseEvent("hello", "hello2"));
    }
}
