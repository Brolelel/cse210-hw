using System;
using System.Collections.Generic;

// Class representing librarians
class Librarian
{
    public string Name { get; set; }
    public int EmployeeID { get; set; }

    public Librarian(string name, int employeeID)
    {
        Name = name;
        EmployeeID = employeeID;
    }

    public void CheckOutItem(LibraryMember member, LibraryItem item)
    {
        if (item.IsAvailable())
        {
            item.BorrowItem();
            Console.WriteLine($"{item.Title} checked out to {member.Name}");
        }
        else
        {
            Console.WriteLine($"{item.Title} is not available.");
        }
    }

    public void CheckInItem(LibraryItem item)
    {
        item.ReturnItem();
        Console.WriteLine($"{item.Title} checked in");
    }
}