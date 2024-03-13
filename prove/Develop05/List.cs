
public class List
{
      public List<Goals> MenuList= new List<Goals>(); 
      string menuinput;

      private int totalPoint = 0;

      public int Pointnumber()
      {
            return totalPoint;

      }
      
      public void Menu()
      {
            while(menuinput != "4")
            {
            Console.WriteLine("------------------------\nThe types of Goals are:");     
            Console.WriteLine("1. Simple Goals");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal\n------------------------");

            Console.WriteLine("Which type of goal would you like to create?");

            menuinput = Console.ReadLine();
            
            string goalname;
            string goaltype;
            int goalpoint;
            int goaltimes = 0 ;
            int Bonus;
            
            switch (menuinput){
                  case "1":
                        Console.WriteLine("Please enter the goal name: ");
                        goalname = Console.ReadLine();
                        Console.WriteLine("What is a short description of it? ");
                        goaltype = Console.ReadLine();
                        Console.WriteLine("what is the amount of points associated with this goal ?  ");
                        goalpoint = int.Parse(Console.ReadLine());
                        // goalnumber +=1;
                        Simple simple = new Simple(goalname,goaltype,goalpoint,false);

                        MenuList.Add(simple);  
                        return;

                  case "2":
                        Console.WriteLine("Please enter the goal name: ");
                        goalname = Console.ReadLine();
                        Console.WriteLine("What is a short description of it? ");
                        goaltype = Console.ReadLine();
                        Console.WriteLine("what is the amount of points associated with this goal ?  ");
                        goalpoint = int.Parse(Console.ReadLine());
                        // goalnumber +=1;
                        Eternal eternal = new Eternal(goalname,goaltype,goalpoint);

                        MenuList.Add(eternal);
                        return;
                  

                  case "3":
                        Console.WriteLine("what's the name of your goal? ");
                        goalname = Console.ReadLine();
                        Console.WriteLine("What is a short description of it? ");
                        goaltype = Console.ReadLine();
                        Console.WriteLine("what is the amount of points associated with this goal ? ");
                        goalpoint = int.Parse(Console.ReadLine());
                        // goalnumber +=1;
                        
                        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                        goaltimes = int.Parse(Console.ReadLine());
                        
                        
                        Console.WriteLine(" What is the bonus for accomplishiing it that many times? ");
                        Bonus = int.Parse(Console.ReadLine());
                        Checklist checklist = new Checklist(goalname,goaltype, goalpoint, 0, goaltimes,Bonus);
                        MenuList.Add(checklist);
                        return;

            }
            }   
      }


      public void DisplayGoals()
      {
            Console.WriteLine(MenuList.Count());
            int i=1;
            foreach (Goals l in MenuList)
            {
                  l.Display(i);
                  i+=1;
            }     
      }     
}