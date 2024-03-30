using System;
using System.Collections.Generic;

// Class representing library members
class LibraryMember
{
    public string Name { get; set; }
    public int ID { get; set; }

    public LibraryMember(string name, int id)
    {
        Name = name;
        ID = id;
    }
}