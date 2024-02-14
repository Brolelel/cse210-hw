public class Reference{

    private string kg_reference;
    private string kg_verse;

    List<string> s_list = new List<string>(){
        "1 Nephi 1: 2|Yea, I make a record in the alanguage of my father, which consists of the learning of the Jews and the language of the Egyptians." , 
        "1 Nephi 1:3|And I know that the record which I make is atrue; and I make it with mine own hand; and I make it according to my knowledge.",
        "John 3:12|Now the names of the twelve apostles are these; The first, Simon, who is called Peter, and Andrew his brother; James the son of Zebedee, and John his brother;"
    };
     

    public Reference (){
        Console.WriteLine("Plean enter from 0 - 2 in order to get your scripture: ");
        int userinput=  int.Parse(Console.ReadLine());
        string[] parts = s_list[userinput].Split("|");
        kg_reference = parts[0];
        kg_verse = parts[1];
        
    }

    public string getReference(){
        
        return kg_reference;
    }

    public string getVerse(){
        return kg_verse;
    }
}