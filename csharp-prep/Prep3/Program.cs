using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        int guess = -1;

        do
        {
            Console.Write("What is your guess? ");
            string userInputGuess = Console.ReadLine();
            guess = int.Parse(userInputGuess);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);

    }
}