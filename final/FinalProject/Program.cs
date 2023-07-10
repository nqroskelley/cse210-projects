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
        Unit _unit = new Unit(null, 0);

        Console.WriteLine("Welcome to the Unit Conversion Program!");

        while (_input1 != "quit" && _input1 != "Quit")
        {
          Console.WriteLine("");

          _input1 = _menu.UnitMenu();

          Console.Clear();

          if (_input1 == "1" || _input1 == "2" || _input1 == "3" || _input1 == "4")
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

              if (_input1 == "1")
              {
                _unit = new Inch(_input2, _number);
              }
              else if (_input1 == "2")
              {
                _unit = new Foot(_input2, _number);
              }
              else if (_input1 == "3")
              {
                _unit = new Yard(_input2, _number);
              }
              else if (_input1 == "4")
              {
                _unit = new Mile(_input2, _number);
              }
              else if (_input1 == "5")
              {
                _unit = new Millimeter(_input2, _number);
              }
              else if (_input1 == "6")
              {
                _unit = new Centimeter(_input2, _number);
              }
              else if (_input1 == "7")
              {
                _unit = new Meter(_input2, _number);
              }
              else if (_input1 == "8")
              {
                _unit = new Kilometer(_input2, _number);
              }
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

              if (_input1 == "1")
              {
                _unit = new Ounce(_input2, _number);
              }
              else if (_input1 == "2")
              {
                _unit = new Pound(_input2, _number);
              }
              else if (_input1 == "3")
              {
                _unit = new Ton(_input2, _number);
              }
              else if (_input1 == "4")
              {
                _unit = new Milligram(_input2, _number);
              }
              else if (_input1 == "5")
              {
                _unit = new Gram(_input2, _number);
              }
              else if (_input1 == "6")
              {
                _unit = new Kilogram(_input2, _number);
              }
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

              if (_input1 == "1")
              {
                _unit = new Second(_input2, _number);
              }
              else if (_input1 == "2")
              {
                _unit = new Minute(_input2, _number);
              }
              else if (_input1 == "3")
              {
                _unit = new Hour(_input2, _number);
              }
              else if (_input1 == "4")
              {
                _unit = new Day(_input2, _number);
              }
              else if (_input1 == "5")
              {
                _unit = new Week(_input2, _number);
              }
              else if (_input1 == "6")
              {
                _unit = new Month(_input2, _number);
              }
              else if (_input1 == "7")
              {
                _unit = new Year(_input2, _number);
              }
            } else if (_input1 == "4")
            {
              _input1 =_menu.TemperatureMenu();

              Console.Clear();

              Console.WriteLine("What amount do you wish to convert?");

              _number = _numberChecker.CheckNumber();

              Console.Clear();

              Console.WriteLine("What unit of temperature do you want to convert it to?");

              _input2 = _menu.TemperatureMenu();

              if (_input1 == "1")
              {
                _unit = new Kelvin(_input2, _number);
              }
              else if (_input1 == "2")
              {
                _unit = new Celsius(_input2, _number);
              }
              else if (_input1 == "3")
              {
                _unit = new Fahrenheit(_input2, _number);
              }
            }

            _unit.DisplayResult();
          }
          else if (_input1 == "quit" || _input1 == "Quit")
          {
            Console.WriteLine("Goodbye!");
          }
        }
    }
}