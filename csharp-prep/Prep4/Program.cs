using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int sum = 0;
        int largestNumber = 0;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        do
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
                
            }
            
            if (number > largestNumber)
            {
                largestNumber = number;
            }

        } while (number != 0);
        
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}