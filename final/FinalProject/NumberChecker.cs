using System;

class NumberChecker
{
  private string _string;
  private double _double;

  public double CheckNumber ()
  {
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

    return _double;
  }
}