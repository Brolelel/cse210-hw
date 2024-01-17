using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

    //Functions

    //     retuenType FunctionName (paramType paramName1, paramType paramName2)
    //     {
    //         FunctionName body
    //     }

        int Add2(int number) {
            return number + 2;
        }

        int more = Add2(10);

    //void
        void PrintName(string name) {
            if (name.Length == 0) {
                return;
            }
            System.Console.WriteLine($"Name is {name}");
            return;
        }

        PrintName("Bob");
        

    
    
    }

}