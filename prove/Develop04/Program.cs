using System;

class Program
{
    static void Main(string[] args)
    {   
        string entry ="";
        Breathing breathing = new Breathing();
        Reflecting reflecting= new Reflecting();
        Listing listing= new Listing();
        do{
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1.Start breathing activity");
            Console.WriteLine("    2.Start reflecting activity");
            Console.WriteLine("    3.Start listing activity");
            Console.WriteLine("    4.Quit");
            entry = Console.ReadLine();

            if(entry =="1" ){
                breathing.inro();
                breathing.do_activity();
                breathing.end();
            }
            else if (entry=="2"){
                reflecting.inro();

                reflecting.end();
            }
            else if (entry=="3"){
                listing.inro();
                listing.end();
            }


        }
        while(entry!="4");
    }
}