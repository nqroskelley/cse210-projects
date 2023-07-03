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
          _menu.UnitMenu();

          _input = Console.ReadLine();
        }
    }
}