using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); 

        int guessedNumber = -1;

        while (guessedNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessedNumber = int.Parse(Console.ReadLine());

            if (magicNumber > guessedNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessedNumber) 
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
