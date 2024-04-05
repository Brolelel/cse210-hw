using System;
using System.Collections.Generic;

// Class representing the library
class Library
{
    public List<LibraryItem> Catalog { get; set; }
    public List<LibraryMember> Members { get; set; }
    public List<Librarian> Librarians { get; set; }
    public Dictionary<string, string> UserCredentials { get; set; }

    public Library()
    {
        Catalog = new List<LibraryItem>();
        Members = new List<LibraryMember>();
        Librarians = new List<Librarian>();
        UserCredentials = new Dictionary<string, string>();
    }

    public void AddItem(LibraryItem item)
    {
        Catalog.Add(item);
    }

    public void AddMember(LibraryMember member)
    {
        Members.Add(member);
    }

    public void AddLibrarian(Librarian librarian)
    {
        Librarians.Add(librarian);
    }

    public void DisplayCatalog()
    {
        foreach (var item in Catalog)
        {
            item.DisplayDetails();
            Console.WriteLine();
        }
    }

    public void AddBook(string title, string author, int year, int pages)
    {
        Catalog.Add(new Book(title, author, year, pages));
        Console.WriteLine($"{title} added to the catalog.");
    }

    public void RegisterUser(string username, string password)
    {
        UserCredentials[username] = password;
        Console.WriteLine("Registration successful.");
    }

    public bool Authenticate(string username, string password)
    {
        if (UserCredentials.ContainsKey(username))
        {
            return UserCredentials[username] == password;
        }
        else
        {
            Console.WriteLine("Username not found.");
            return false;
        }
    }
}
