using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userEntry = -1;

        while (userEntry != 0)
        {
            Console.Write("Enter a list of numbers. [Type 0 when finished] " );
            string response = Console.ReadLine();
            userEntry = int.Parse(response);

                if (userEntry != 0)
                {
                   numbers.Add(userEntry);
                }

            
        }

        // Computing the sum of the numbers.
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Computing average

        float ave = ((float)sum / numbers.Count);

        Console.WriteLine($"The average is: {ave}");


        // Getting the highest number

        int largest = numbers[0];

        foreach (int entry in numbers)
        {
            if (entry > largest)
            {
                largest = entry;
            }

        }

        Console.WriteLine($"The largest number is: {largest}");

        
    }
}