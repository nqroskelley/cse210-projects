using System;

class Program
{
    static void Main(string[] args)
    {
        string _choice = "";
        BreathingActivity _breathig = new BreathingActivity("Breathing", "This activity will assist you in practicing slow and steady breathing in order to help you relax.");
        ReflectionActivity _reflection = new ReflectionActivity("Reflection", "This activity will assist you in reflecting on your past experiences in order to help you recognize your strengths.");
        ListingActivity _listing = new ListingActivity("Listing", "This activity will assit you in recognizing the good things in your life by helping you to count your blessings.");

        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (_choice != "4")
        {
          Console.WriteLine("Please select which activity you would like to do:");
          Console.WriteLine("1. Breathing Activity");
          Console.WriteLine("2. Reflection Activity");
          Console.WriteLine("3. Listing Activity");
          Console.WriteLine("4. Quit");

          _choice = Console.ReadLine();

          if (_choice == "1")
          {}
          else if (_choice == "2")
          {}
          else if (_choice == "3")
          {}
          else if (_choice == "4")
          {
            Console.WriteLine("Goodbye!");
          }
          else
          {
            Console.WriteLine("Sorry, I didn't understand that.");
          }
        }
    }
}