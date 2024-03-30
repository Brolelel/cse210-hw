using System;
using System.Collections.Generic;

// Derived class representing books
class Book : LibraryItem
{
    public int Pages { get; set; }

    public Book(string title, string author, int year, int pages) : base(title, author, year)
    {
        Pages = pages;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Pages: {Pages}");
    }
}