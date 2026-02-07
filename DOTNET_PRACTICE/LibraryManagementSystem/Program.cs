using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LibraryManagementSystem;

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter;

        string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");

        if (string.IsNullOrEmpty(outputPath))
        {
            textWriter = Console.Out;
        }
        else
        {
            textWriter = new StreamWriter(outputPath, true);
        }

        ILibrarySystem librarySystem = new LibrarySystem();

        int bCount = Convert.ToInt32(Console.ReadLine().Trim());

        for (int i = 0; i < bCount; i++)
        {
            var a = Console.ReadLine().Trim().Split(" ");

            IBook book = new Book
            {
                Id = Convert.ToInt32(a[0]),
                Title = a[1],
                Author = a[2],
                Category = a[3],
                Price = Convert.ToInt32(a[4])
            };

            int quantity = Convert.ToInt32(a[5]);

            librarySystem.AddBook(book, quantity);
        }

        textWriter.WriteLine("Book Info:");
        var booksInfo = librarySystem.BooksInfo();

        foreach (var (title, quantity, price) in booksInfo.OrderBy(x => x.Item1))
        {
            textWriter.WriteLine($"Book Name:{title}, Quantity:{quantity}, Price:{price}");
        }

        textWriter.WriteLine("Category Total Price:");
        var categoryTotalPrice = librarySystem.CategoryTotalPrice();

        foreach (var (category, totalPrice) in categoryTotalPrice.OrderBy(x => x.Item1))
        {
            textWriter.WriteLine($"Category:{category}, Total Price:{totalPrice}");
        }

        textWriter.WriteLine("Category And Author With Count:");
        var categoryAndAuthorWithCount = librarySystem.CategoryAndAuthorWithCount();

        foreach (var (category, author, count) in categoryAndAuthorWithCount
                     .OrderBy(x => x.Item1)
                     .ThenBy(x => x.Item2))
        {
            textWriter.WriteLine($"Category:{category}, Author:{author}, Count:{count}");
        }

        int total = librarySystem.CalculateTotal();
        textWriter.WriteLine($"Total Price: {total}");

        textWriter.Flush();

        if (textWriter != Console.Out)
        {
            textWriter.Close();
        }
    }
}
