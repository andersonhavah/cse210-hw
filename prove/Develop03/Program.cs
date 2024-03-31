using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a new scripture
        Scripture scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        // Display the initial scripture
        DisplayScripture(scripture);

        // Main loop for hiding words
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide a few random words
            scripture.HideRandomWords(2);

            // Display the updated scripture
            DisplayScripture(scripture);
        }

        Console.WriteLine("\nProgram ended. Press any key to exit.");
        Console.ReadKey();
    }
    static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}