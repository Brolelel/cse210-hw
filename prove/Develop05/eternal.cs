// Jayton Crockett, Austin Reeves, Jacob Strong, Michael Torres, and Kyle Guo
public class Eternal:Goals{
   public Eternal(string name, string type, int point):base(name,type,point){}
   public override void Display(int i){
      Console.WriteLine($"The goals are:\n{i} [ ] {_ar_name} ({_ar_type})");
   }
   public override string Saveformat(){
      return $"Eternal Goals:{_ar_name},{_ar_type},{_ar_point}";
   }
   public override int CompletedGoals(){
      return _ar_point;
   }    
}

