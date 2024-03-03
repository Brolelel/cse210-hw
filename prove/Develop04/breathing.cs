class Breathing:Activity{
    public Breathing(){
        activity = "Breathing";
        description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        
    }

    public void do_activity(){
        DateTime startTime = DateTime.Now;

        while (DateTime.Now < startTime.AddSeconds(duration))
        {
            Console.Write("Breathe in...");
            Thread.Sleep(1000);
            Console.Write("5");
            Console.Write("\b \b");

            Thread.Sleep(1000);
            Console.Write("4");
            Console.Write("\b \b");

            Thread.Sleep(1000);
            Console.Write("3");
            Console.Write("\b \b");

            Thread.Sleep(1000);
            Console.Write("2");
            Console.Write("\b \b");

            Thread.Sleep(1000);
            Console.Write("1");
            Console.Write("\b \b");
            
            Console.Write("Breathe out...");

            Thread.Sleep(1000);
            Console.Write("5");
            Console.Write("\b \b");

            Thread.Sleep(1000);
            Console.Write("4");
            Console.Write("\b \b");

            Thread.Sleep(1000);
            Console.Write("3");
            Console.Write("\b \b");

            Thread.Sleep(1000);
            Console.Write("2");
            Console.Write("\b \b");

            Thread.Sleep(1000);
            Console.Write("1");
            Console.Write("\b \b");
            
            
        }
    }

}