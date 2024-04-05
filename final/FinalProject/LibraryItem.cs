using System;
using System.Collections.Generic;


class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    private bool Availability { get; set; } = true; // Private field to track availability

    public LibraryItem(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public bool IsAvailable() // Public method to check availability
    {
        return Availability;
    }

    public void BorrowItem() // Public method to borrow the item
    {
        Availability = false;
    }

    public void ReturnItem() // Public method to return the item
    {
        Availability = true;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nYear: {Year}");
    }
}
