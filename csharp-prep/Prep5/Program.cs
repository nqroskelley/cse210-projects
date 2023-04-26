using System;

class Program
{
    static void Main(string[] args)
    {
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
          string numberString = Console.ReadLine();
          int number = int.Parse(numberString);
          return number;
        }

        static int SquareNumber(int number)
        {
          int square = number * number;
          return square;
        }

        static void DisplayResult(string name, int square)
        {
          string squareString = square.ToString();
          Console.WriteLine($"{name}, the square of your number is {squareString}");
        }

        DisplayWelcome();
        DisplayResult(PromptUserName(),SquareNumber(PromptUserNumber()));
    }
}