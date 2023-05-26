using System;
//The following features have been implemented to exceed requirements:
//The program always selects unhidden words to hide.
//Three different scriptures for the user to choose from at the start.
class Program
{
    static void Main(string[] args)
    {
        string _input = "";
        Reference _reference;
        Scripture _scripture = null;

        Console.WriteLine("Welcome! Which scripture would you like to memorize? (To exit, type 'quit')");
        Console.WriteLine("");
        while (_input != "1" && _input != "2" && _input != "3" && _input != "quit")
        {
          Console.WriteLine("1. Proverbs 3:5-6");
          Console.WriteLine("2. John 3:16");
          Console.WriteLine("3. James 1:5-6");

          _input = Console.ReadLine();

          if (_input == "1")
          {
            _reference = new Reference("Proverbs", 3, 5, 6);
            _scripture = new Scripture(_reference.GetReference(), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
          }
          else if (_input == "2")
          {
            _reference = new Reference("John", 3, 16);
            _scripture = new Scripture(_reference.GetReference(), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
          }
          else if (_input == "3")
          {
            _reference = new Reference("james", 1, 5, 6);
            _scripture = new Scripture(_reference.GetReference(), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
          }
          else if (_input == "quit")
          {}
          else
          {
            Console.WriteLine("Sorry, I didn't understand that. Please select 1, 2, or 3, or type 'quit' to exit.");
          }
        }
        while (_input != "quit")
        {
          _scripture.Display();
          Console.WriteLine("");
          Console.WriteLine("Press enter to continue or type 'quit' to exit.");
          _input = Console.ReadLine();
          if (_input != "quit")
          {
            _input = _scripture.HideWords();
          }
        }
        Console.Write("Goodbye!");
    }
}