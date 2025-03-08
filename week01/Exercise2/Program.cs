using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade porcentage? ");
        string value = Console.ReadLine();
        int grade = int.Parse(value);

        if (grade >= 90)
        {
            Console.WriteLine("Your letter grade is A");

        }

        else if (grade >= 89)
        {
            Console.WriteLine("Your letter grade is B");
        }

        else if (grade >= 79)
        {
            Console.WriteLine("Your letter grade is C");
        }

        else if (grade >= 69)
        {
            Console.WriteLine("Your letter grade is D");

        }

        else 
        {
            Console.WriteLine("Your letter grade is E");
        }


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