using System;

public class Entry
{
    public string _entry;
    public string _prompt;
    public string _date;

    List<string> prompt = new List<string>(){
        "What was the best thing that happened to you today?",
        "What is one thing you wish you could have done differently?",
        "Who was your favorite person to talk to?",
        "Did I meet anyone interesting today?",
        "Did I do anything meaningful today?",
        "Did I meet my personal goals today?",
        "What was the coolest thing I saw today?",
        "What was an interesting thought I had today?",
        "What was something I could have done differently?"

    };


    public void promptquestion(){
        
        int numberofpromt= prompt.Count;
        Random rnm = new Random();
        int rindex= rnm.Next(numberofpromt);
        _prompt = prompt[rindex];
        Console.WriteLine(_prompt);
        Console.WriteLine("Please enter your entry");
        _entry = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        
    }

    // Random rnm = new Random();
    // return prompt(rnm.Next(promt.Count));

}


