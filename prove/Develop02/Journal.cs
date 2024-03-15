using System.Data;
using System.IO; 
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        // set and store today's date
        DateTime currentTime = DateTime.Now;
        newEntry._date = currentTime.ToShortDateString();

        // generate and display a prompt
        PromptGenerator generator = new PromptGenerator();
        newEntry._promptText = generator.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);

        // ask and store user input
        Console.Write("> ");
        newEntry._entryText = Console.ReadLine();
        Console.WriteLine("");
        
        // add entry to _entries list above
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}~ {e._promptText}~ {e._entryText}");
            }
            
        }
        Console.WriteLine("Entries saved!");
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Entry newEntry = new Entry();

            newEntry._date = parts[0];
            newEntry._promptText = parts[1]; 
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
        Console.WriteLine("Entries loaded!");
    }
}