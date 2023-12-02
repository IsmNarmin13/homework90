using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEntity
{
    internal class Library : IEntity
    {
        private static int nextId = 1;

        public int Id { get; }
        public int BookLimit { get; }
        private Book[] Books { get; set; }

        public Library(int bookLimit)
        {
            Id = nextId++;
            BookLimit = bookLimit;
            Books = new Book[0];
        }

        public void AddBook(Book newBook)
        {
            if (Array.Exists(Books, book => book.Name == newBook.Name && !book.IsDeleted))
            {
                throw new Utils.Exceptions.AlreadyExistsException($"A book with the name '{newBook.Name}' already exists.");
            }

            if (Books.Length >= BookLimit)
            {
                throw new Utils.Exceptions.CapacityLimitException($"Library has reached its book limit of {BookLimit}.");
            }

            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = newBook;
        }

        public Book GetBookById(int id)
        {
            Book foundBook = Array.Find(Books, book => book.Id == id && !book.IsDeleted);

            if (foundBook == null)
            {
                throw new Utils.Exceptions.NotFoundException($"Book with ID {id} not found.");
            }

            return foundBook;
        }
    }
}
