using System;

class Program
{
    static void Main(string[] args)
    {
        // This message lets the user know what the program is about and what they will do.
        Console.WriteLine("This is a guessing game where the user types a number to find the generated number by the computer.");

        // Generate a random the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("The magic number is already generated. Now, you find it.\n");

        int guessNumber;

        do
        {
            // Ask the user their guessed number
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (guessNumber != magicNumber);

    }
}