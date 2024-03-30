using System;
using System.Collections.Generic;


class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    private bool Availability { get; set; } = true; 

    public LibraryItem(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public bool IsAvailable() 
    {
        return Availability;
    }

    public void BorrowItem() 
    {
        Availability = false;
    }

    public void ReturnItem() 
    {
        Availability = true;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nYear: {Year}");
    }
}