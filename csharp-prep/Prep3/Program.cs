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

        // do-while loop
        int anotherCount = 0;
        do {
            System.Console.WriteLine($"AnotherCount = {++anotherCount}");
        } while (anotherCount < 10);

        // for loop
        for(int i=0; i<5; i++){
            System.Console.WriteLine($"i = {i}");
        }
    }
}