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

        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
    }
}