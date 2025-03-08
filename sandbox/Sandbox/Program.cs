using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World. This is the Sandbox Project.");
        Console.WriteLine("Maina");

        int number = 5;
        number = 9;
        number = number + 3;
        Console.WriteLine($" {number}.");

        string color = "Blue";
        Console.WriteLine($"I like the color {color}.");

        Console.Write("What is your favorite color? ");
        string favcolor = Console.ReadLine();
        Console.WriteLine($"Your fav color is {favcolor}");
       
    
    }
}