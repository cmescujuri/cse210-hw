using System.IO;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        string filename = "prompts.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _prompts.Add(line);
        }

        Random randomGenerator = new Random();
        int length = (_prompts.Count);
        int magicNumber = randomGenerator.Next(0,length);
        string randomPrompt = _prompts[magicNumber];

        return randomPrompt;
    }
}