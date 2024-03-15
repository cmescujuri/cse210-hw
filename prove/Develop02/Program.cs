using System;

class Program
{
    static void Main(string[] args)
    {
        int answerInt = 0;
        Journal myJournal = new Journal();

        while (answerInt != 5)
        {
            Console.WriteLine("Welcome to the Magic Journal!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            string answerString = Console.ReadLine();
            answerInt = int.Parse(answerString);
            Console.WriteLine("");

            if (answerInt == 1)
            {
                Entry newEntry = new Entry();
                myJournal.AddEntry(newEntry);
            }
            if (answerInt == 2)
            {
                myJournal.DisplayAll();
            }
            if (answerInt == 3)
            {
                myJournal.LoadFromFile("myFile.txt");
            }
            if (answerInt == 4)
            {
                myJournal.SaveToFile("myFile.txt");
            }
        } 
        
        Console.WriteLine("Thank you -- see you later!");
    }
}