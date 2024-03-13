
public class Goals
{
   protected bool isChecked = false;
   protected string _ar_name = "";
   protected string _ar_type = "";
   protected int _ar_point = 0;



   public Goals(string name, string type, int point)
   {
      _ar_name = name;
      _ar_type = type;
      _ar_point = point;
   }

   public virtual void Display(int i){}
   public virtual int CompletedGoals()
   {
      if(isChecked == false){
         isChecked = true;
         return _ar_point;
      }
      else{
         return 0;
      }
   }

   public virtual string Saveformat()
   {
      return "";
   }

}