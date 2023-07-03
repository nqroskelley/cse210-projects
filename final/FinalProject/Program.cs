using System;

class Program
{
    static void Main(string[] args)
    {
        string _input1 = "";
        string _input2 = "";
        double _number;
        Menu _menu = new Menu();
        NumberChecker _numberChecker = new NumberChecker();

        Console.WriteLine("Welcome to the Unit Conversion Program!");

        while (_input1 != "quit" && _input1 != "Quit")
        {
          Console.WriteLine("");

          _menu.UnitMenu();

          _input1 = Console.ReadLine();

          Console.Clear();

          if (_input1 == "1" || _input1 == "2" || _input1 == "3")
          {
            Console.WriteLine("Pick your starting unit.");

            if (_input1 == "1")
            {
              _menu.LengthMenu();

              _input1 = Console.ReadLine();

              Console.Clear();

              Console.WriteLine("What amount do you wish to convert?");

              _number = _numberChecker.CheckNumber();

              Console.Clear();

              Console.WriteLine("What unit of length do you want to convert it to?");

              _menu.LengthMenu();

              _input2 = Console.ReadLine();
            }
            else if (_input1 == "2")
            {
              _menu.MassMenu();

              _input1 = Console.ReadLine();

              Console.Clear();

              Console.WriteLine("What amount do you wish to convert?");

              _number = _numberChecker.CheckNumber();

              Console.Clear();

              Console.WriteLine("What unit of mass do you want to convert it to?");

              _menu.MassMenu();

              _input2 = Console.ReadLine();
            }
            else if (_input1 == "3")
            {
              _menu.TimeMenu();

              _input1 = Console.ReadLine();

              Console.Clear();

              Console.WriteLine("What amount do you wish to convert?");

              _number = _numberChecker.CheckNumber();

              Console.Clear();

              Console.WriteLine("What unit of time do you want to convert it to?");

              _menu.TimeMenu();

              _input2 = Console.ReadLine();
            }

          }
          else if (_input1 == "quit" || _input1 == "Quit")
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