using System;
using System.Collections.Generic;


class LibraryMember
{
    public string Name { get; set; }
    public int ID { get; set; }

    public LibraryMember(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public void BorrowItem(LibraryItem item)
    {
        if (item.IsAvailable())
        {
            item.BorrowItem();
            Console.WriteLine($"{item.Title} borrowed by {Name}");
        }
        else
        {
            Console.WriteLine($"{item.Title} is not available for borrowing.");
        }
    }

    public void ReturnItem(LibraryItem item)
    {
        item.ReturnItem();
        Console.WriteLine($"{item.Title} returned by {Name}");
    }
}