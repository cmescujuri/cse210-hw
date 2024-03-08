using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        }

        string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        int PromptUserNumber ()
        {
            Console.Write("Please enter your favorite number: ");
            string answer = Console.ReadLine();
            int number = int.Parse(answer);
            return number;
        }

        int SquareNumber (int number)
        {
            int square = number * number;
            return square;
        }

        void DisplayResult (string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber (number);

        DisplayResult (name, square);
    }
}