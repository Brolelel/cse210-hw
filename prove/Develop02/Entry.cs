public class Entry {
    public string response;
    public string prompt;
    public string date;

    public void Display(){
        List<string> promptList = new List<string>();  
        promptList.Add("Who was the most interesting person I interacted with today? ");
        promptList.Add("What was the best part of my day? ");
        promptList.Add("How did I see the hand of the Lord in my life today? ");
        promptList.Add("What was the strongest emotion I felt today? ");
        promptList.Add("If I had one thing I could do over today, what would it be? ");

        Random R = new Random();

        int someRandomNumber = R.Next(0, promptList.Count());

		writeQuestion = Console.WriteLine(promptList.ElementAt(someRandomNumber));
        return writeQuestion
    }
}