// Jayton Crockett, Austin Reeves, Jacob Strong, Michael Torres, and Kyle Guo
public class SaveLoad{
      public SaveLoad(){}
      public void _save(List<Goals>MenuList){
        Console.WriteLine("Please entry the file name: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName)){      
            int i =0;
            foreach(Goals entry in MenuList){
                i+=1;
                outputFile.WriteLine(entry.Saveformat());
            }
        }
    }

    public void _load(List<Goals> MenuList){
        Console.WriteLine("Please entry your file name: ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines){
            string[] parts = line.Split(":");
         if (parts[0]== "simpleGoals"){
            string[] parts2 = parts[1].Split(",");
            Simple simple = new Simple(parts2[0],parts2[1],int.Parse(parts2[2]),bool.Parse(parts2[3]));
            MenuList.Add(simple);
         }
         else if (parts[0]== "EternalGoals"){
            string[] parts2 = parts[1].Split(",");
            Eternal eternal = new Eternal(parts2[0],parts2[1],int.Parse(parts2[2]));
            MenuList.Add(eternal);
         }
         else if (parts[0]== "Checklist"){
            string[] parts2 = parts[1].Split(",");
            Checklist checklist = new Checklist(parts2[0],parts2[1],int.Parse(parts2[2]),int.Parse(parts2[3]),int.Parse(parts2[4]),int.Parse(parts2[5]));
            MenuList.Add(checklist);
         }
      }
   }
}
      

