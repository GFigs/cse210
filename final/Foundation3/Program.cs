using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lectureEvent = new Lecture("Dora The Explorer", 500, "Adventure Time", "Dora will teach how is to live in the wild", "June 20th", "8 PM", "st Mary st 234", "Lunapark");
        Reception receptionEvent = new Reception("confirm@gmail.com", "Wedding", "The celebration of John and Melisa's marriage", "February 28th", "6 PM", "Belgrano 2234", "Buenos Aires");
        OutdoorGathering OutdoorEvent = new OutdoorGathering("cloudy", "Firework Show", "A firework show to celebrate new year", "December 31st", "11 PM", "Blvrd Maritimo", "Mar del Plata");

        Console.WriteLine(lectureEvent.ShortDescription());
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("");

        Console.WriteLine(receptionEvent.ShortDescription());
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("");

        Console.WriteLine(OutdoorEvent.ShortDescription());
        Console.WriteLine(OutdoorEvent.GetStandardDetails());
        Console.WriteLine(OutdoorEvent.GetFullDetails());
        Console.WriteLine("");
    }
}