using System;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("admin", "password"); 
        Console.WriteLine("Please Login to access services.");
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        if (user1.Authenticate(username, password))
        {
            Console.WriteLine("Login successful.");

            // example data from other classes
            LibraryMember member1 = new LibraryMember("John", 1001);
            Librarian librarian1 = new Librarian("Alice", 2001);
            Library library = new Library();

            // Adding items, members, and librarians to the library
            library.AddMember(member1);
            library.AddLibrarian(librarian1);

            // Displaying the library catalog
            library.DisplayCatalog();

            // Add a book
            Console.WriteLine("Adding a new book:");
            Console.Write("Title: ");
            string newTitle = Console.ReadLine();
            Console.Write("Author: ");
            string newAuthor = Console.ReadLine();
            Console.Write("Year: ");
            int newYear = int.Parse(Console.ReadLine());
            Console.Write("Pages: ");
            int newPages = int.Parse(Console.ReadLine());
            library.AddBook(newTitle, newAuthor, newYear, newPages);
        }
        else
        {
            Console.WriteLine("Login failed.");
        }
    }
}