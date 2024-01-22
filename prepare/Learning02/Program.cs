using System;
public class Car {
    public int milesPerGallon;
    public int gallons;
    public string make;
    public string model;
    public int TotalRange() {
        return gallons * milesPerGallon;
    }
    public void Display() {
        System.Console.WriteLine($"{make} {model}: Range= {TotalRange()}");
    }
}

class Program
{
    static void Main(string[] args)
    {   
        var cars = new List<Car>();

        var car = new Car();
            car.make = "Honda";
            car.model = "Civic";
            car.gallons = 10;
            car.milesPerGallon = 30;
            cars.Add(car);

            car = new Car();
            car.make = "Ford";
            car.model = "F-150";
            car.gallons = 30;
            car.milesPerGallon = 5;
            cars.Add(car);

            foreach (var c in cars)
            {
                // System.Console.WriteLine($"{c.make} {c.model}: Range = {c.gallons * c.milesPerGallon}");
                c.Display();
                int range = c.TotalRange
            }
    }
}