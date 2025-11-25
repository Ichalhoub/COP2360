using System;
using System.Collections.Generic;

public class Contractor
{
    public string Name { get; set; }
    public string Number { get; set; }
    public DateTime StartDate { get; set; }

    public Contractor(string name, string number, DateTime startDate)
    {
        Name = name;
        Number = number;
        StartDate = startDate;
    }
}

public class Subcontractor : Contractor
{
    public int Shift { get; set; }
    public double HourlyPayRate { get; set; }

    public Subcontractor(string name, string number, DateTime startDate, int shift, double hourlyPayRate)
        : base(name, number, startDate)
    {
        Shift = shift;
        HourlyPayRate = hourlyPayRate;
    }

    public float ComputePay(double hours)
    {
        double factor = Shift == 2 ? 1.03 : 1.0;
        return (float)(hours * HourlyPayRate * factor);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Subcontractor> subs = new List<Subcontractor>();
        string input;

        do
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            Console.Write("Enter start date (yyyy-mm-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter shift (1/2): ");
            int shift = int.Parse(Console.ReadLine());
            Console.Write("Enter hourly rate: ");
            double rate = double.Parse(Console.ReadLine());

            subs.Add(new Subcontractor(name, number, startDate, shift, rate));

            Console.Write("Add another? (y/n): ");
            input = Console.ReadLine();
        } while (input.ToLower() == "y");

        foreach (var sub in subs)
        {
            Console.WriteLine($"Name: {sub.Name}, Pay for 40 hours: {sub.ComputePay(40)}");
        }
    }
}