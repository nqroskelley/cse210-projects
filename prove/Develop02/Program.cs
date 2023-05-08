using System;

class Program
{
    static void Main(string[] args)
    {
        bool finished = false;
        string choice = "";
        Console.WriteLine("Welcome to the Journal Program!");

        while (finished != true)
        {
          Console.WriteLine("Please enter the number corresponding to the option you wish to select:");
          Console.WriteLine("1. Write in Journal");
          Console.WriteLine("2. Display Journal");
          Console.WriteLine("3. Load Journal");
          Console.WriteLine("4. Save Journal");
          Console.WriteLine("5. Exit");
          Console.Write("What would you like to do? ");
          choice = Console.ReadLine();
          if (choice == "1")
          {}
          else if (choice == "2")
          {}
          else if (choice == "3")
          {}
          else if (choice == "4")
          {}
          else if (choice == "5")
          {
            Console.Write("Goodbye!");
            finished = true;
          }
          else
          {
            Console.WriteLine("Sorry, I didn't understand that.");
          }
        }
    }
}