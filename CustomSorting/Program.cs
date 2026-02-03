using System;
using System.Collections.Generic;

class Student
{
    public string Name;
    public int Age;
    public int Marks;
}

class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        int marksCompare = y.Marks.CompareTo(x.Marks);
        if (marksCompare != 0)
            return marksCompare;

        return x.Age.CompareTo(y.Age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(':');
            students.Add(new Student
            {
                Name = input[0],
                Age = int.Parse(input[1]),
                Marks = int.Parse(input[2])
            });
        }

        students.Sort(new StudentComparer());

        foreach (var s in students)
        {
            Console.WriteLine(s.Name + " " + s.Age + " " + s.Marks);
        }
    }
}
