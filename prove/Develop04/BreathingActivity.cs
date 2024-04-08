public class BreathingActivity : Activity
{

    // This is the constructor of the class
    public BreathingActivity()
    {
        SetName("Welcome to the Breathing Activity.");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        ShowSpinner(3);

        // Implement breathing in/out logic
        for (int i = 0; i * i < GetDuration(); i++) 
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(i);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(i);
            Console.WriteLine("");
        }

        ShowSpinner(3);
        DisplayEndingMessage();
    }
}