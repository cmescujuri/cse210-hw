using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentString = Console.ReadLine();
        int gradePercent = int.Parse(gradePercentString);

        string grade = "";

        if (gradePercent >= 90)
        {
            grade = "A";
        }

        else if (gradePercent >= 80)
        {
            grade = "B";
        }
        
        else if (gradePercent >= 70)
        {
            grade = "C";
        }
        
        else if (gradePercent >= 60)
        {
            grade = "D";
        }

        else 
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}.");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Hooray -- you passed!");
        }

        else 
        {
            Console.WriteLine("You failed. Better luck next time!");
        }
    }
}