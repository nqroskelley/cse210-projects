using System;

class Program
{
    static void Main(string[] args)
    {
        bool finished = false;
        string choice = "";
        List<Entry> _entries = new List<Entry>();
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
          {
            Entry entry = new Entry();
            Prompt prompt = new Prompt();
            prompt.GetPrompt();
            entry._prompt = prompt._prompt;
            Console.Write("> ");
            entry._entry = Console.ReadLine();
            DateTime dateTime = DateTime.Now;
            entry._date = dateTime.ToShortDateString();
            _entries.Add(entry);
          }
          else if (choice == "2")
          {
            foreach(Entry entry in _entries)
            {
              entry.DisplayEntry();
            }
          }
          else if (choice == "3")
          {
            Console.WriteLine("Please enter the filename");
          }
          else if (choice == "4")
          {
            Console.WriteLine("Please name the file.");
          }
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