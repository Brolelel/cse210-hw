using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;

class Program
{   
    
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        // //list - new keyword
        // List<int> myInts = new List<int>();
        // var moreInt = new List<int>();

        // moreInt.Add(34);
        // moreInt.Add(10);

        // //Iterate over items
        // foreach(var n in moreInt) {
        //     System.Console.WriteLine($"n = {n}");
        // }
        

        List<int> numbers = new List<int>();
        // List<string> words = new List<string>();
        int listNumber = -1;

        while (listNumber != 0)
        {
            System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            System.Console.Write("Enter number: ");
            listNumber = int.Parse(Console.ReadLine());
            // Only add the number to the list if it is not 0
            if (listNumber != 0)
            {
                numbers.Add(listNumber);
            }
            

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
        

     }
}