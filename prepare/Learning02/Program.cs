using System;
public class Car {
    public int milesPerGallon;
    public int gallons;
    public string make;
    public string model;

    public Owner owner;

    public Car(string make, string model, int gallons, int milesPerGallon, Owner owner){
        this.make = make;
        this.model = model;
        this.gallons = gallons;
        this.milesPerGallon = milesPerGallon;
        this.owner = owner;
    }
    public int TotalRange() {
        return gallons * milesPerGallon;
    }
    public void Display() {
        System.Console.WriteLine($"{make} {model} {owner.name}: Range= {TotalRange()}");
    }
}

public class Owner{
    public string name;
    public string phone;
}

class Program
{
    static void Main(string[] args)
    {   
        var cars = new List<Car>();

        var car = new Car("Honda", "Civic", 10,30,owner);
            car.make = "Honda";
            car.model = "Civic";
            car.gallons = 10;
            car.milesPerGallon = 30;
            var owner = new Owner();
            owner.name = "Michael";
            owner.phone = "302-4030";
            car.owner = owner;
            cars.Add(car);

            car = new Car();
            car.make = "Ford";
            car.model = "F-150";
            car.gallons = 30;
            car.milesPerGallon = 5;
            owner = new Owner();
            owner.name = "Brendan";
            owner.phone = "405-2048";
            cars.Add(car);

            foreach (var c in cars)
            {
                // System.Console.WriteLine($"{c.make} {c.model}: Range = {c.gallons * c.milesPerGallon}");
                c.Display();
                int range = c.TotalRange();
            }
    }
}