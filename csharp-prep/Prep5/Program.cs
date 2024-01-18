using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Console.WriteLine("Hello Prep5 World!");

//     //Functions

//     //     retuenType FunctionName (paramType paramName1, paramType paramName2)
//     //     {
//     //         FunctionName body
//     //     }

//     //     int Add2(int number) {
//     //         return number + 2;
//     //     }

//     //     int more = Add2(10);

//     // //void = def in python
//     //     void PrintName(string name) {
//     //         if (name.Length == 0) {
//     //             return;
//     //         }
//     //         System.Console.WriteLine($"Name is {name}");
//     //         return;
//     //     }

//     //     PrintName("Bob");
        
//     //     // variable scope

//     //     var y = 0;
//     //     {
//     //         var w = 10;
//     //         w = y + 4;
//     //         y= w + 5;
//     //     }
        
    
    
//     }

// }

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}

