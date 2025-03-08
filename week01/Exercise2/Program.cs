using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        
        Console.Write("What is your grade porcentage? ");
        string value = Console.ReadLine();
        int grade = int.Parse(value);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";

        }

        else if (grade >= 89)
        {
            letter = "B";
        }

        else if (grade >= 79)
        {
            letter = "C";
        }

        else if (grade >= 69)
        {
            letter = "D";

        }

        else 
        {
            letter = "E";
        }

        Console.WriteLine($"Your grade is {letter}");


        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you've passed the course!");
        }

        else
        {
            Console.WriteLine("Never give up, you can try next time!");
        }







        
    }
}