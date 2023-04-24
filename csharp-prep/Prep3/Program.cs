using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
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