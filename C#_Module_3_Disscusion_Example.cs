using System;

public class Engine
{
    public string Type { get; set; }
    public void Start() => Console.WriteLine("Engine started.");
}

public class Vehicle
{
    public string Model { get; set; }
    public Engine Engine { get; set; } = new Engine { Type = "V8" };

    public void Drive()
    {
        Engine.Start();
        Console.WriteLine($"{Model} is driving.");
    }
}

class Program
{
    static void Main()
    {
        var car = new Vehicle { Model = "Toyota" };
        car.Drive();
    }
}