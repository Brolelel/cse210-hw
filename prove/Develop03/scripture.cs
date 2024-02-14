using System;

public class Scripture{

private string reference;
List<Word> words= new List<Word>();
public List<int> numbers = new List<int>();

    public Scripture(Reference scripture ){
        reference = scripture.getReference();
        int counter = 0;
        string[] parts = scripture.getVerse().Split(" ");
        foreach(string part in parts){
            numbers.Add(counter);
            Word word = new Word(part);
            words.Add(word);
            counter+=1;
        }

    }

    public void display(){
        Console.Write(reference + " - ");
        foreach(Word word in words){
            word.show_word();
        }
    }

    public void hide_word(){

        try{
            Random rword = new Random();
            int rum = rword.Next(numbers.Count);
            words[numbers[rum]].hide_word();
            numbers.RemoveAt(rum);
        }
        catch{

        }
       
    }




}