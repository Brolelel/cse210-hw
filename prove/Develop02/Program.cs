using System;



class Program
{
    static void Main(string[] args)
    {   
        List<Entry> entries = new List<Entry>();
        string number = "0";
        Save _save=  new Save();
        Load _load= new Load();
        while (number !="5"){
            Console.WriteLine("Welcome to the Journal program!");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");
            number = Console.ReadLine();

            if (number== "1"){
                Entry entry = new Entry();
                entry.promptquestion();
                entries.Add(entry);
                
            
            }
            else if (number=="2"){
                foreach(Entry entry in entries){
                    Console.WriteLine(" ");
                    Console.WriteLine($"Entry Data: {entry._date}");
                    Console.WriteLine($"Prompt Asked: {entry._prompt}");
                    Console.WriteLine($"Answer from User: {entry._entry}");
                    Console.WriteLine(" ");
                }
            }
            else if (number=="3"){
                _load._load(entries);

            }
            else if (number=="4"){
                _save._save(entries);

            }
            
            
        }
            

    }
}