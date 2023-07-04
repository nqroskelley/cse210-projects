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

          _input1 = _menu.UnitMenu();

          Console.Clear();

          if (_input1 == "1" || _input1 == "2" || _input1 == "3")
          {
            Console.WriteLine("Pick your starting unit.");

            if (_input1 == "1")
            {
              _input1 = _menu.LengthMenu();

              Console.Clear();

              Console.WriteLine("What amount do you wish to convert?");

              _number = _numberChecker.CheckNumber();

              Console.Clear();
           
              Console.WriteLine("What unit of length do you want to convert it to?");

              _input2 = _menu.LengthMenu();

              if (_input2 == "1")
              {}
              else if (_input2 == "2")
              {}
              else if (_input2 == "3")
              {}
              else if (_input2 == "4")
              {}
              else if (_input2 == "5")
              {}
              else if (_input2 == "6")
              {}
              else if (_input2 == "7")
              {}
              else if (_input2 == "8")
              {}
            }
            else if (_input1 == "2")
            {
              _input1 =_menu.MassMenu();

              Console.Clear();

              Console.WriteLine("What amount do you wish to convert?");

              _number = _numberChecker.CheckNumber();

              Console.Clear();

              Console.WriteLine("What unit of mass do you want to convert it to?");

              _input2 = _menu.MassMenu();

              if (_input2 == "1")
              {}
              else if (_input2 == "2")
              {}
              else if (_input2 == "3")
              {}
              else if (_input2 == "4")
              {}
              else if (_input2 == "5")
              {}
              else if (_input2 == "6")
              {}
            }
            else if (_input1 == "3")
            {
              _input1 = _menu.TimeMenu();

              Console.Clear();

              Console.WriteLine("What amount do you wish to convert?");

              _number = _numberChecker.CheckNumber();

              Console.Clear();

              Console.WriteLine("What unit of time do you want to convert it to?");

              _input2 = _menu.TimeMenu();

              if (_input2 == "1")
              {}
              else if (_input2 == "2")
              {}
              else if (_input2 == "3")
              {}
              else if (_input2 == "4")
              {}
              else if (_input2 == "5")
              {}
              else if (_input2 == "6")
              {}
              else if (_input2 == "7")
              {}
            }
          }
          else if (_input1 == "quit" || _input1 == "Quit")
          {
            Console.WriteLine("Goodbye!");
          }
        }
    }
}