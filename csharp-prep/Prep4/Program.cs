using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Declare variables
        int number;
        List<int> numbers = new List<int>();
        double sumOfNumbers = 0;
        double averageOfNumbers = 0;
        int largestNumber;

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
            numbers.Add(number);
            }
        } while (number != 0);

        // Calculate the sum of all numbers
        foreach (int num in numbers)
        {
            sumOfNumbers += num;

        }

        // Calculate the average of all numbers
        foreach (int num in numbers)
        {
            averageOfNumbers = sumOfNumbers / numbers.Count;
        }

        // Get the largest number from the numbers' list
        largestNumber = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largestNumber)
            {
                // This substitutes the value of the largest number with the newfound value
                largestNumber = num;
            }
        }
        
        Console.WriteLine($"The sum is: {sumOfNumbers}");
        Console.WriteLine($"The average is: {averageOfNumbers}");
        Console.WriteLine($"The largest number is: {largestNumber}");


    }
}