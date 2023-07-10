using System;

class Menu
{
  private string _choice;

  public string UnitMenu ()
  {
    Console.WriteLine("What kind of unit do you want to convert?");
    Console.WriteLine("1. Length");
    Console.WriteLine("2. Mass");
    Console.WriteLine("3. Time");

    do
    {
      _choice = Console.ReadLine();

      if (_choice != "1" && _choice != "2" && _choice != "3" && _choice != "quit" && _choice != "Quit")
      {
        Console.WriteLine("Sorry, I didn't understand that.");

        _choice = "";
      }
    } while (_choice == "");

    return _choice;
  }

  public string LengthMenu ()
  {
    Console.WriteLine("1. Inches");
    Console.WriteLine("2. Feet");
    Console.WriteLine("3. Yards");
    Console.WriteLine("4. Miles");
    Console.WriteLine("5. Millimeters");
    Console.WriteLine("6. Centimeters");
    Console.WriteLine("7. Meters");
    Console.WriteLine("8. Kilometers");

    do
    {
      _choice = Console.ReadLine();

      if (_choice != "1" && _choice != "2" && _choice != "3" && _choice != "4" && _choice != "5" && _choice != "6" && _choice != "7" && _choice != "8")
      {
        Console.WriteLine("Sorry, I didn't understand that.");

        _choice = "";
      }
    } while (_choice == "");

    return _choice;
  }

  public string MassMenu ()
  {
    Console.WriteLine("1. Ounces");
    Console.WriteLine("2. Pounds");
    Console.WriteLine("3. Tons");
    Console.WriteLine("4. Milligrams");
    Console.WriteLine("5. Grams");
    Console.WriteLine("6. Kilograms");

    do
    {
      _choice = Console.ReadLine();

      if (_choice != "1" && _choice != "2" && _choice != "3" && _choice != "4" && _choice != "5" && _choice != "6")
      {
        Console.WriteLine("Sorry, I didn't understand that.");

        _choice = "";
      }
    } while (_choice == "");

    return _choice;
  }

  public string TimeMenu ()
  {
    Console.WriteLine("1. Seconds");
    Console.WriteLine("2. Minutes");
    Console.WriteLine("3. Hours");
    Console.WriteLine("4. Days");
    Console.WriteLine("5. Weeks");
    Console.WriteLine("6. Months");
    Console.WriteLine("7. Years");

    do
    {
      _choice = Console.ReadLine();

      if (_choice != "1" && _choice != "2" && _choice != "3" && _choice != "4" && _choice != "5" && _choice != "6" && _choice != "7")
      {
        Console.WriteLine("Sorry, I didn't understand that.");

        _choice = "";
      }
    } while (_choice == "");

    return _choice;
  }

  public string TemperatureMenu ()
  {
    Console.WriteLine("1. Kelvin");
    Console.WriteLine("2. Celsius");
    Console.WriteLine("3. Fahrenheit");

    do
    {
      _choice = Console.ReadLine();

      if (_choice != "1" && _choice != "2" && _choice != "3")
      {
        Console.WriteLine("Sorry, I didn't understand that.");

        _choice = "";
      }
    } while (_choice == "");

    return _choice;
  }
}