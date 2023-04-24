using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your magic number? ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        int guess;

        do
        {
          Console.Write("What is your guess? ");
          string guessString = Console.ReadLine();
          guess = int.Parse(guessString);

          if (guess < number)
          {
            Console.WriteLine("Higher");
          }
          else if (guess > number)
          {
            Console.WriteLine("Lower");
          }
          else
          {
            Console.WriteLine("You guessed it!");
          }
        } while (guess != number);
    }
}