
public class Checklist:Goals

{
      
      protected int _jc_goalCount;
      protected int _jc_currentCount;
      protected int _jc_bonusPoint;
      List<Goals> MenuList= new List<Goals>();
      public Checklist(string name, string type, int point,int currentGoalCount,int goalCount,int bonus):base(name,type,point)
      {
            _jc_goalCount = goalCount;
            _jc_bonusPoint = bonus;
            _jc_currentCount = currentGoalCount;


      }

      public override void Display(int i)

      {
            if (isChecked)
        {
        Console.WriteLine($"The goals are:\n{i} [x] {_ar_name} ({_ar_type})");
        Console.WriteLine($"Points completed:{_jc_currentCount}/{_jc_goalCount}");
        Console.WriteLine($"You have {_ar_point} points!");
        }    
        
        
        else
        {
            
         Console.WriteLine($"The goals are:\n{i} [x] {_ar_name} ({_ar_type})");
         Console.WriteLine($"Points completed:{_jc_currentCount}/{_jc_goalCount}");
        }
                        
      }

    public override string Saveformat()
   {
      return $"Checklist:{_ar_name},{_ar_type},{_ar_point},{_jc_currentCount},{_jc_goalCount},{_jc_bonusPoint}";
   }

    public override int CompletedGoals()
   {
     if (isChecked == false) {
         _jc_currentCount += 1;
      if ( _jc_currentCount == _jc_goalCount){
         isChecked = true;
         Console.WriteLine("!!!");
         return _ar_point + _jc_bonusPoint; 
      }else{
         return _ar_point;
      }}else{
         return 0;
      }    
        
         
    }
       

}
