using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        // Student student = new Student("id1", "John", "Computer Engineering");
        // Faculty faculty = new Faculty ("id2", "Professor Joe", "Biology")

        // student.Display();
        // faculty.Display();

        // List<Person> people = new List<Person>();
        // people.Add(student);
        // people.Add(faculty);
    }
}

// //Person

// class Person {
//     protected string id;
//     protected string name;

//     public Person(string id, string name){
//         this.id = id;
//         this.name = name;
//     } 
// }

// //student
// class Student: Person {
//     private string major;

//     public Student(string id, string name, string major): base(id,name) {
//         this.major = major;
//     }
// }

// // Faculty

// class Faculty: Person{
//     private string department;

//     public Faculty(string id, string name, string department): base(id,name) {
//         this.
//     }
// }



//Vehicle

class Vehicle{
    private string make;
    private string model;
    private int miles;

    public Vehicle(string make, string model, int miles){
        this.make = make;
        this.model = model;
        this.miles = miles;

    }
}

class Car : Vehicle{
    public Car(string make, string model, int miles, int towing) : base(make, model, miles) {}
}

class Truck : Vehicle{
    private int towing;

    public Truck(string make, string model, int miles, int towing) : base(make, model, miles) {
        this.towing = towing;
    }
}