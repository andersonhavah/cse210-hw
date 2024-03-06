using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the user first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Get the user last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Display the user's full name to the console
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
        
    }
}