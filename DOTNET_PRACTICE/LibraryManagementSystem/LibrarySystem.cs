using System.Collections.Generic;
using System.Linq;
namespace LibraryManagementSystem
{
    public class LibrarySystem : ILibrarySystem
    {
        private Dictionary<IBook, int> books = new Dictionary<IBook, int>();

        public void AddBook(IBook book, int quantity)
        {
            var existingBook = books.Keys.FirstOrDefault(b => b.Id == book.Id);

            if (existingBook != null)
            {
                books[existingBook] += quantity;
            }
            else
            {
                books.Add(book, quantity);
            }
        }

        public void RemoveBook(IBook book, int quantity)
        {
            var existingBook = books.Keys.FirstOrDefault(b => b.Id == book.Id);

            if (existingBook != null)
            {
                books[existingBook] -= quantity;

                if (books[existingBook] <= 0)
                {
                    books.Remove(existingBook);
                }
            }
        }

        public int CalculateTotal()
        {
            int total = 0;

            foreach (var item in books)
            {
                total += item.Key.Price * item.Value;
            }

            return total;
        }

        public List<(string, int, int)> BooksInfo()
        {
            var result = new List<(string, int, int)>();

            foreach (var item in books)
            {
                result.Add((
                    item.Key.Title,
                    item.Value,
                    item.Key.Price * item.Value
                ));
            }

            return result;
        }

        public List<(string, int)> CategoryTotalPrice()
        {
            return books
                .GroupBy(b => b.Key.Category)
                .Select(g => (
                    g.Key,
                    g.Sum(x => x.Key.Price * x.Value)
                ))
                .ToList();
        }

        public List<(string, string, int)> CategoryAndAuthorWithCount()
        {
            return books
                .GroupBy(b => new { b.Key.Category, b.Key.Author })
                .Select(g => (
                    g.Key.Category,
                    g.Key.Author,
                    g.Sum(x => x.Value)
                ))
                .ToList();
        }
    }
}