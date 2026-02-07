using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public int Marks { get; set; }
}

public class StudentUtility
{
    public Dictionary<string, string> GetStudentDetails(string id)
    {
        var result = new Dictionary<string, string>();

        var student = Program.studentDetails.Values
                        .FirstOrDefault(s => s.Id == id);

        if (student != null)
        {
            result.Add(student.Id, $"{student.Name}_{student.Course}");
        }

        return result;
    }

    public Dictionary<string, Student> UpdateStudentMarks(string id, int marks)
    {
        var result = new Dictionary<string, Student>();

        var student = Program.studentDetails.Values
                        .FirstOrDefault(s => s.Id == id);

        if (student != null)
        {
            student.Marks = marks;
            result.Add(student.Id, student);
        }

        return result;
    }
}

public class Program
{
    public static Dictionary<int, Student> studentDetails =
        new Dictionary<int, Student>();

    public static void Main()
    {
        studentDetails.Add(1, new Student { Id = "101", Name = "Nevin", Course = "FullStack", Marks = 99 });
        studentDetails.Add(2, new Student { Id = "102", Name = "Dsouza", Course = "DS", Marks = 100 });
        studentDetails.Add(3, new Student { Id = "102", Name = "Lazy", Course = ".NET", Marks = 69 });

        StudentUtility utility = new StudentUtility();

        while (true)
        {
            Console.WriteLine("1. Get Student Details");
            Console.WriteLine("2. Update Marks");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the student id");
                string id = Console.ReadLine();

                var result = utility.GetStudentDetails(id);

                if (result.Count == 0)
                {
                    Console.WriteLine("Student id not found");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine($"{item.Key}   {item.Value}");
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the student id");
                string id = Console.ReadLine();

                Console.WriteLine("Enter the marks");
                int marks = int.Parse(Console.ReadLine());

                var result = utility.UpdateStudentMarks(id, marks);

                if (result.Count == 0)
                {
                    Console.WriteLine("Student id not found");
                }
                else
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine($"{item.Key}   {item.Value.Name}   {item.Value.Course}   {item.Value.Marks}");
                    }
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thank you");
                break;
            }
        }
    }
}
