using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //while loop
        int count =5;

        while (count < 10)
        {
            System.Console.WriteLine($"Count = {count++}");
            count++;
        }


        while (count < 10)
        {
            System.Console.WriteLine($"Count = {count}");
            count++;
        }

    }
}