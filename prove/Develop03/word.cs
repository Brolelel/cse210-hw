using System;

public class Word{

    private string kg_word;

    public Word(string word){
        kg_word = word;
    }

    public void hide_word(){
        int letternum = kg_word.Count();
        kg_word = "";
        for (int i = 0; i < letternum; i++){
            kg_word=kg_word + "_";
        }
    }
    public void show_word(){
        Console.Write(kg_word + " ");
    }


}