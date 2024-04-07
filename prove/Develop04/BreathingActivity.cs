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
        for (int i = 0; i < GetDuration(); i++)
        {
            if(i % 2 == 0)
            Console.Write("Breathe in...");
            ShowCountDown(i);
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
        }

        DisplayEndingMessage();
    }
}