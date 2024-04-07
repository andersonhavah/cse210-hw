public class BreathingActivity : Activity
{

    // This is the constructor of the class
    public BreathingActivity()
    {
        SetName("Welcome to the Breathing Activity.\n");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. \n ");
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        // Console.Write("How long, in seconds, would you like for your sessions?");
        // _duration = int.Parse(Console.ReadLine());
        ShowSpinner(3);

        // Implement breathing in/out logic
        for (int i = 2; i < GetDuration(); i++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("Now breathe out...");
            ShowCountDown(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}