using IEntity;

try
{
    // Create a library with a book limit of 5
    Library myLibrary = new Library(5);

    // Add books to the library
    myLibrary.AddBook(new Book("Book1", "Author1", 200));
    myLibrary.AddBook(new Book("Book2", "Author2", 150));
    myLibrary.AddBook(new Book("Book3", "Author3", 300));

    // Try adding a book with the same name (will throw AlreadyExistsException)
    myLibrary.AddBook(new Book("Book1", "Author4", 180));

    // Print information about each book in the library
    foreach (var book in myLibrary.Books)
    {
        book.ShowInfo();
    }

    // Get a book by ID
    Book retrievedBook = myLibrary.GetBookById(2);
    Console.WriteLine("\nRetrieved Book:");
    retrievedBook.ShowInfo();

    // Try getting a non-existing book (will throw NotFoundException)
    Book nonExistingBook = myLibrary.GetBookById(10);
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}
        }