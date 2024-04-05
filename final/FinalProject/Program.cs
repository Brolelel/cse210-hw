using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Login:");
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                if (library.Authenticate(username, password))
                {
                    Console.WriteLine("Login successful.");
                    PerformLibraryActions(library);
                }
                else
                {
                    Console.WriteLine("Login failed.");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Registration:");
                Console.Write("Enter a username: ");
                string newUsername = Console.ReadLine();
                Console.Write("Enter a password: ");
                string newPassword = Console.ReadLine();
                library.RegisterUser(newUsername, newPassword);
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }

    static void PerformLibraryActions(Library library)
    {
        // Creating instances of classes
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, 180);
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960, 281);
        LibraryMember member1 = new LibraryMember("John", 1001);
        Librarian librarian1 = new Librarian("Alice", 2001);

        // Adding items, members, and librarians to the library
        library.AddItem(book1);
        library.AddItem(book2);
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
}