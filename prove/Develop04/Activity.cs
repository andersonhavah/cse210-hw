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
        Console.WriteLine($"{_name}");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your sessions? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Thread.Sleep(1000); // Pause for 3 seconds
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"Duration: {_duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    public void ShowSpinner(int seconds)
    {
        // for (int i = 0; i < seconds; i++)
        // {
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Console.Write("\b \b");
            Console.WriteLine();
        // }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}");
            Thread.Sleep(1000); // Pause for 1 second
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