using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // This method adds a new Entry in the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!");
    }

    // This method display every entry in the journal
    public void DisplayAll()
    {
        Console.WriteLine("\n===== Journal Entries =====");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // This method saves the entries of the user to a file
    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
            Console.WriteLine($"Journal saved to \"{file}\" successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to file: {ex.Message}");
        }
    }

    // This method loads the saved entries of the user from a file
    public void LoadFromFile(string file)
    {
        try
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string promptText = parts[1];
                    string entryText = parts[2];
                    Entry loadedEntry = new Entry(date, promptText, entryText);
                    _entries.Add(loadedEntry);
                }
            }
            Console.WriteLine($"Journal loaded from \"{file}\" successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: \"{file}\" in {ex.Message}.");
            Console.WriteLine("Check the filename again to make sure it's well written. Maybe the file you requested doesn't exist");
        }
    }
}