using System;
using System.Linq;
using System.Text.Json;

namespace StringFormat
{
    public record Student(string Name, int Score);

    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            int minScore = int.Parse(Console.ReadLine());

            var students = items
                .Select(x =>
                {
                    var idx = x.LastIndexOf(':');
                    var name = x.Substring(0, idx);
                    var score = int.Parse(x.Substring(idx + 1));
                    return new Student(name, score);
                })
                .Where(s => s.Score >= minScore)
                .OrderByDescending(s => s.Score)
                .ThenBy(s => s.Name)
                .ToArray();

            string json = JsonSerializer.Serialize(students);
            Console.WriteLine(json);
        }
    }
}
