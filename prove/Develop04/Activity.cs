public class Activity
{
    // Declare the attributes off the Activity class
    private string _name;
    private string _description;
    private int _duration;

    // This is the constructor of the class
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n{_name}\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your sessions? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Thread.Sleep(1000); // Pause for 3 seconds
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job! Well done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}\n");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    public void ShowSpinner(int seconds)
    {
        int elapsedTime = 0;
        char[] spinnerChars = new char[] { '-', '\\', '|', '/' };
        int currentCharIndex = 0;

        while (elapsedTime < seconds * 1000) // Convert seconds to milliseconds
        {
            Console.Write(spinnerChars[currentCharIndex]);
            Thread.Sleep(500); // Adjust sleep time for desired animation speed

            Console.Write("\b \b"); // Erase previous character and space for spinner movement
            currentCharIndex = (currentCharIndex + 1) % spinnerChars.Length;
            elapsedTime += 500;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b");
        }
    }

    // Below are the getters
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    // Below are the setters
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
}