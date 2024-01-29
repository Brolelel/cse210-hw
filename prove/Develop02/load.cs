using System;

public class Load
{



    
    public void _load(List<Entry> entries){
        Console.WriteLine("Please entry your file name: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
    
        {
            string[] parts = line.Split(",");
            Entry entry = new Entry();

            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];
            entries.Add(entry);
        }
    }
    
}
