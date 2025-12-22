using System;

namespace Day2Console;

public class Student
{
    #region Fields
    int rollNo;
    string name;
    string addr;

    #endregion
    
    /// <summary>
    /// Default Constructor for Student Class
    /// </summary>
    public Student()
    {
        rollNo = 100;
        name = "Dummy";
        addr = "Dummy City";
    }
    public Student(int id ,string name ,string city)
    {
        rollNo = id;
        this.name = name;
        addr = city;
    }

    public void DisplayDetails(Student s1)
    {
        System.Console.WriteLine("RollNo : {0}\nName : {1}\nAddress : {2}",s1.rollNo , s1.name , s1.addr);
    }

}