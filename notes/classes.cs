// A code template for the category of things known as Person. The
    // responsibility of a Person is to hold and display personal information.
    public class Person
    {
        // The C# convention is to start member variables with an underscore _
        public string _givenName = "";
        public string _familyName = "";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Person()
        {
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }

        // A method that displays the person's full name as used in western 
        // countries or <given name family name>.
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }
    }

    // public class Car {
//     public int milesPerGallon;
//     public int gallons;
//     public string make;
//     public string model;
//     public int TotalRange() {
//         return gallons * milesPerGallon;
//     }
//     public void Display() {
//         System.Console.WriteLine($"{make} {model}: Range= {TotalRange()}");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {   
//         var cars = new List<Car>();

//         var car = new Car();
//             car.make = "Honda";
//             car.model = "Civic";
//             car.gallons = 10;
//             car.milesPerGallon = 30;
//             cars.Add(car);

//             car = new Car();
//             car.make = "Ford";
//             car.model = "F-150";
//             car.gallons = 30;
//             car.milesPerGallon = 5;
//             cars.Add(car);

//             foreach (var c in cars)
//             {
//                 // System.Console.WriteLine($"{c.make} {c.model}: Range = {c.gallons * c.milesPerGallon}");
//                 c.Display();
//                 int range = c.TotalRange
//             }
//     }
// }