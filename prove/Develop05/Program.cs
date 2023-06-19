using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest program!");
        Console.WriteLine("");

        List<Goal> _goals = new List<Goal>();
        int _score = 0;
        int _points;
        int _times;
        int _bonus;
        string _choice = "";
        string _filename;
        string _goalname;
        string _description;
        string _pointString;
        string _timeString;
        string _bonusString;

        while (_choice != "6")
        {
          Console.WriteLine($"Score: {_score}");
          Console.WriteLine("");
          Console.WriteLine("What would you like to do?");
          Console.WriteLine("1. Create goal");
          Console.WriteLine("2. View goals");
          Console.WriteLine("3. Save");
          Console.WriteLine("4. Load");
          Console.WriteLine("5. Record event");
          Console.WriteLine("6. Quit");

          _choice = Console.ReadLine();

          if (_choice == "1")
          {
            _choice = "0";
            Console.Clear();
            while (_choice != "1" && _choice != "2" && _choice != "3" && _choice != "4")
            {
              Console.WriteLine("What type of goal would you like to make?");
              Console.WriteLine("1. Simple goal");
              Console.WriteLine("2. Eternal goal");
              Console.WriteLine("3. Checklist goal");
              Console.WriteLine("4. Cancel");

              _choice = Console.ReadLine();

              if (_choice == "1" || _choice == "2" || _choice == "3")
              {
                Console.Clear();
                Console.WriteLine("What would you like to name the goal?");

                _goalname = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("Please give a description of your goal.");

                _description = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("How many points is this goal worth?");

                _points = 0;

                while (_points == 0)
                {
                  _pointString = Console.ReadLine();

                  if (Int32.TryParse(_pointString, out _points) && _points != 0)
                  {}
                  else
                  {
                    Console.WriteLine("Please enter a non-zero number.");
                  }
                }

                if (_choice == "1")
                {
                  _goals.Add(new SimpleGoal());
                } 
                else if (_choice == "2")
                {
                  _goals.Add(new EternalGoal());
                }
                else if (_choice == "3")
                {
                  Console.WriteLine("");
                  Console.WriteLine("How many times must this goal be completed?");

                  _times = 0;

                  while (_times == 0)
                  {
                    _timeString = Console.ReadLine();

                    if (Int32.TryParse(_timeString, out _times) && _times != 0)
                    {}
                    else
                    {
                      Console.WriteLine("Please enter a non-zero number.");
                    }
                  }

                  Console.WriteLine("");
                  Console.WriteLine($"How many bonus points is completing this goal {_times} times worth?");

                  _bonus = 0;

                  while (_bonus == 0)
                  {
                    _bonusString = Console.ReadLine();

                    if (Int32.TryParse(_bonusString, out _bonus) && _bonus != 0)
                    {}
                    else
                    {
                      Console.WriteLine("Please enter a non-zero number.");
                    }
                  }

                  _goals.Add(new ChecklistGoal());
                }
              }
              else if (_choice == "4")
              {}
              else
              {
                Console.Clear();
                Console.WriteLine("Sorry, I didn't understand that.");
                Console.WriteLine("");
              }
            }

            Console.Clear();
          }
          else if (_choice == "2")
          {}
          else if (_choice == "3")
          {}
          else if (_choice == "4")
          {}
          else if (_choice == "5")
          {}
          else if (_choice == "6")
          {
            Console.WriteLine("Goodbye!");
          }
          else
          {
            Console.Clear();
            Console.WriteLine("Sorry, I didn't understand that.");
            Console.WriteLine("");
          }
        }
    }
}