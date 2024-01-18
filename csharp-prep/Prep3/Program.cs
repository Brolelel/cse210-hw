using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // //while loop
        // int count =5;

        // while (count < 10)
        // {
        //     System.Console.WriteLine($"Count = {count++}");
        //     count++;
        // }


        // while (count < 10)
        // {
        //     System.Console.WriteLine($"Count = {count}");
        //     count++;
        // }

        // // do-while loop
        // int anotherCount = 0;
        // do {
        //     System.Console.WriteLine($"AnotherCount = {++anotherCount}");
        // } while (anotherCount < 10);

        // // for loop
        // for(int i=0; i<5; i++){
        //     System.Console.WriteLine($"i = {i}");
        // }




        // class prep homework

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        Console.WriteLine($"The magic number is {number}.");
        int guessNumber = -1;

        while (guessNumber != number)
        {
            Console.Write("what is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > number)
            {
                System.Console.WriteLine("Too High");
            }
            else if (guessNumber < number)
            {
                System.Console.WriteLine("Too Low");
            }
            else
            {
                System.Console.WriteLine("Correct");
            }
        }
    }
}