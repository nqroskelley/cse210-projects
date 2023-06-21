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
        int _goalNumber;
        int _index;
        string _choice = "";
        string _filename;
        string _goalname;
        string _description;
        NumberChecker _numberChecker = new NumberChecker();

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

                _points = _numberChecker.CheckNumber();

                if (_choice == "1")
                {
                  _goals.Add(new SimpleGoal(_goalname, _description, _points, false));
                } 
                else if (_choice == "2")
                {
                  _goals.Add(new EternalGoal(_goalname, _description, _points));
                }
                else if (_choice == "3")
                {
                  Console.WriteLine("");
                  Console.WriteLine("How many times must this goal be completed?");

                  _times = _numberChecker.CheckNumber();

                  Console.WriteLine("");
                  Console.WriteLine($"How many bonus points is completing this goal {_times} times worth?");

                  _bonus = _numberChecker.CheckNumber();

                  _goals.Add(new ChecklistGoal(_goalname, _description, _points, 0, _times, _bonus));
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
          {
            Console.Clear();

            foreach (Goal goal in _goals)
            {
              goal.Display();
            }

            Console.WriteLine("");
          }
          else if (_choice == "3")
          {
            Console.WriteLine("Please name the file.");

            _filename = Console.ReadLine();

            using (StreamWriter outputfile = new StreamWriter(_filename))
            {
              outputfile.WriteLine(_score);

              foreach (Goal goal in _goals)
              {
                outputfile.WriteLine(goal.GetStringRepresentation());
              }
            }

            Console.Clear();
          }
          else if (_choice == "4")
          {
            Console.WriteLine("What is the name of the file?");

            _filename = Console.ReadLine();

            string[] _lines = System.IO.File.ReadAllLines(_filename);

            foreach (string line in _lines)
            {
              string[] _parts1 = line.Split("^");

              string _type = _parts1[0];

              if (_type == "simple")
              {
                string[] _parts2 = _parts1[1].Split("|");

                _goals.Add(new SimpleGoal(_parts2[0], _parts2[1], Int32.Parse(_parts2[2]), Convert.ToBoolean(_parts2[3])));
              }
              else if (_type == "eternal")
              {
                string[] _parts2 = _parts1[1].Split("|");

                _goals.Add(new EternalGoal(_parts2[0], _parts2[1], Int32.Parse(_parts2[2])));
              }
              else if (_type == "checklist")
              {
                string[] _parts2 = _parts1[1].Split("|");

                _goals.Add(new ChecklistGoal(_parts2[0], _parts2[1], Int32.Parse(_parts2[2]), Int32.Parse(_parts2[3]), Int32.Parse(_parts2[4]), Int32.Parse(_parts2[5])));
              }
              else
              {
                _score = Int32.Parse(_type);
              }
            }

            Console.Clear();
          }
          else if (_choice == "5")
          {
            Console.Clear();
            Console.WriteLine("Which goal have you completed?");

            _goalNumber = 0;

            foreach (Goal goal in _goals)
            {
              _goalNumber++;
              Console.WriteLine($"{_goalNumber}. {goal.GetName()}");
            }

            _index = _numberChecker.CheckNumber() - 1;

            _score = _score + _goals[_index].RecordEvent();

            Console.Clear();
          }
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