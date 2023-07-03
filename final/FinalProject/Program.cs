using System;

class Program
{
    static void Main(string[] args)
    {
        string _input = "";
        double _number;
        Menu _menu = new Menu();

        Console.WriteLine("Welcome to the Unit Conversion Program!");

        while (_input != "quit" && _input != "Quit")
        {
          Console.WriteLine("");

          _menu.UnitMenu();

          _input = Console.ReadLine();

          if (_input == "1")
          {
            _menu.LengthMenu();
          }
          else if (_input == "2")
          {
            _menu.MassMenu();
          }
          else if (_input == "3")
          {
            _menu.TimeMenue();
          }
          else if (_input == "quit" || _input == "Quit")
          {
            Console.WriteLine("Goodbye!");
          }
          else
          {
            Console.Clear();
            Console.WriteLine("Sorry, I didn't understand that.");
          }
        }
    }
}