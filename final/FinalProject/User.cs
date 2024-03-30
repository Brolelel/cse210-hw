using System;
using System.Collections.Generic;

class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public bool Authenticate(string username, string password)
    {
        return Username == username && Password == password;
    }
}
