using System;

public class Save
{
    public void _save(List<Entry>entries){
        Console.WriteLine("Please entry the file name: ");

        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in entries){
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._entry}");

            }
            // You can add text to the file with the WriteLine method
            
        }

    }

}