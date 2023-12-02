using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEntity
{
    public class Book : IEntity
    {
        private static int nextId = 1;

        public int Id { get; }
        public string Name { get; }
        public string AuthorName { get; }
        public int PageCount { get; }
        public bool IsDeleted { get; set; }

        public Book(string name, string authorName, int pageCount)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(authorName) || pageCount <= 0)
            {
                throw new ArgumentException("Name, authorName, and pageCount are required.");
            }

            Id = nextId++;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            IsDeleted = false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Author: {AuthorName}, Page Count: {PageCount}, IsDeleted: {IsDeleted}");
        }

        public static bool operator >(Book book1, Book book2)
        {
            return book1.PageCount > book2.PageCount;
        }

        public static bool operator <(Book book1, Book book2)
        {
            return book1.PageCount < book2.PageCount;
        }
    }
}