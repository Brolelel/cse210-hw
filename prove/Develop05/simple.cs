// Jayton Crockett, Austin Reeves, Jacob Strong, Michael Torres, and Kyle Guo
public class Simple:Goals{

public Simple(string name, string type, int point,bool isChecked):base(name,type,point){
      this.isChecked = isChecked;
   }
   public override void Display(int i){
      if (isChecked){
         Console.WriteLine("~----------------------~\nThe goals are:");
         Console.WriteLine($"{i} [X] {_ar_name} ({_ar_type}) ");
         Console.WriteLine($"You have  {_ar_point} points\n~----------------------~");
      }    
      else{
         Console.WriteLine("~----------------------~\nThe goals are:");
         Console.WriteLine($"{i} [ ] {_ar_name} ({_ar_type}) \n~----------------------~");
      }
   }
   public override string Saveformat(){
      return $"simpleGoals:{_ar_name},{_ar_type},{_ar_point},{isChecked}";
   }
}
