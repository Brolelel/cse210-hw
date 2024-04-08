using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        while (true)
        {      
            Console.WriteLine("Welcome to the City Library!");
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
                    Console.WriteLine("Please choose option 2 to register an account.");
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
        while (true)
        {
            Console.WriteLine("1. Display Catalog");
            Console.WriteLine("2. Add Book");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Logout");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Catalog:");
                library.DisplayCatalog();
            }
            else if (choice == "2")
            {
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
            else if (choice == "3")
            {
                Console.WriteLine("Borrow Book:");
                Console.Write("Enter your name: ");
                string memberName = Console.ReadLine();
                LibraryMember member = library.Members.Find(m => m.Name == memberName);
                if (member != null)
                {
                    Console.Write("Enter the title of the book you want to borrow: ");
                    string bookTitle = Console.ReadLine();
                    Book book = library.Catalog.Find(b => b.Title == bookTitle) as Book;
                    if (book != null)
                    {
                        member.BorrowItem(book);
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Member not found.");
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Return Book:");
                Console.Write("Enter your name: ");
                string memberName = Console.ReadLine();
                LibraryMember member = library.Members.Find(m => m.Name == memberName);
                if (member != null)
                {
                    Console.Write("Enter the title of the book you want to return: ");
                    string bookTitle = Console.ReadLine();
                    Book book = library.Catalog.Find(b => b.Title == bookTitle) as Book;
                    if (book != null)
                    {
                        member.ReturnItem(book);
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Member not found.");
                }
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}