using System;

class NumberChecker
{
  private string _string;
  private double _double;

  public double CheckNumber ()
  {
    Console.Clear();

    Console.WriteLine("How many do you wish to convert?");

    do
    {
      _string = Console.ReadLine();

      if (double.TryParse(_string, out _double))
      {}
      else
      {
        Console.WriteLine("Please enter a number.");
        _string = "";
      }
    } while (_string == "");

    Console.Clear();
           
    Console.WriteLine("Pick your ending unit.");

    return _double;
  }
}