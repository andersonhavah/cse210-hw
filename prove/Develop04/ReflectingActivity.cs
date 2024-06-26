public class ReflectingActivity : Activity
{
    // This is the class' attributes
    private List<string> _prompts;
    private List<string> _questions;

    // This is the constructor
    public ReflectingActivity()
    {
        SetName("\nWelcome to the Reflection Activity\n");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            // Add more questions as needed
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(3);

        DisplayPrompt();
        DisplayQuestions();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        string randomPrompt = $"{_prompts[index]}";
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        string randomQuestion = $"Question: {_questions[index]}";
        return randomQuestion;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Thread.Sleep(2000); // Pause for 3 seconds after each prompt
        Console.WriteLine("\nWhen you have something in your mind, press enter to continue.");
        Console.ReadKey();

    }

    public void DisplayQuestions()
    {
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        foreach (string question in _questions)
        {
            Console.Write($"> {question}");
            ShowSpinner(3);
            Thread.Sleep(3000); // Pause for 3 seconds after each question
        }
    }

}