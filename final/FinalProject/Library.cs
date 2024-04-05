using System;
using System.Collections.Generic;


class Library
{
    public List<LibraryItem> Catalog { get; set; }
    public List<LibraryMember> Members { get; set; }
    public List<Librarian> Librarians { get; set; }
    public Dictionary<string, string> UserCredentials { get; set; }
    private const string UserCredentialsFile = "user_credentials.txt";

    public Library()
    {
        Catalog = new List<LibraryItem>();
        Members = new List<LibraryMember>();
        Librarians = new List<Librarian>();
        UserCredentials = new Dictionary<string, string>();

        // Load user credentials from file
        LoadUserCredentials();
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
        SaveUserCredentials(); // Save user credentials to file
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

    private void LoadUserCredentials()
    {
        if (File.Exists(UserCredentialsFile))
        {
            using (StreamReader reader = new StreamReader(UserCredentialsFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        UserCredentials[parts[0]] = parts[1];
                    }
                }
            }
        }
    }

    private void SaveUserCredentials()
    {
        using (StreamWriter writer = new StreamWriter(UserCredentialsFile))
        {
            foreach (var entry in UserCredentials)
            {
                writer.WriteLine($"{entry.Key},{entry.Value}");
            }
        }
    }
}