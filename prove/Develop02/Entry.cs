public class Entry
{
    public string _date;
    public string _entryText;
    public string  _promptText;

    // Create an Entry constructor for the Entry class
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // This method displays to the user what they typed as a reponse to the question
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine("-----------------------------");
    }

}