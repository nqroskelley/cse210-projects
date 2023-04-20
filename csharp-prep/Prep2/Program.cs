using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercent = int.Parse(grade);
        string letter;

        if (gradePercent >= 90)
        {
          letter = "A";
        }
        else if (gradePercent >= 80)
        {
          letter = "B";
        }
        else if (gradePercent >= 70)
        {
          letter = "C";
        }
        else if (gradePercent >= 60)
        {
          letter = "D";
        }
        else
        {
          letter = "F";
        }

        Console.WriteLine(letter);

        if (gradePercent >= 70)
        {
          Console.WriteLine("You passed the course. Great job!");
        }
        else
        {
          Console.WriteLine("Sorry, you didn't pass the course. Better luck next time!");
        }
    }
}