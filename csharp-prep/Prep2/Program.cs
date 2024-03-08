using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare a variable to store the grade letter 
        string gradeLetter;

        // Get the grade percentage from the user
        Console.Write("Enter your grade in percentage (Eg: 80): ");
        string userInput = Console.ReadLine();

        // Convert the user input into an integer
        int gradePercentage = int.Parse(userInput);

        // Check
        if (gradePercentage >= 90)
        {
           gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        // Display to the user their grade letter
        Console.WriteLine($"Your grade is {gradeLetter}.");

        // Output a message to let the user know whether or not they passed the class
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else 
        {
            Console.WriteLine("Sorry, you didn't passed the class! \nGood luck for next time!");
        }
    }
}