using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared =  SquareNumber(userNumber);

        DisplayResult(name, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int numberSquare = number * number;

        return numberSquare;
    }

    static void DisplayResult(string name,int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
}