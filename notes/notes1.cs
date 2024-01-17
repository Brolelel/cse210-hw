
        //var
        var MyName = "Michael";

        //printing variables
        Console.WriteLine("A Name: " + MyName);
        Console.WriteLine($"A Name: {MyName}");

        //readline
        System.Console.WriteLine("What is your age?");
        var ageString = Console.ReadLine();

        //Converting Variables
        var age = int.Parse(ageString);

        //Conditionals
        if (age < 18) {
            System.Console.WriteLine("Your a Minor");
            System.Console.WriteLine("BRUH");
        }
        else{
            System.Console.WriteLine("Your Old");
        }

        // git config --list
        // git config --local user.name ""
        //git config --local user.email ""