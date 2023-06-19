using System;

class NumberChecker
{
  private int _number;
  private string _string;

  public int CheckNumber()
  {
    _number = 0;

    while (_number == 0)
    {
      _string = Console.ReadLine();

      if (Int32.TryParse(_string, out _number) && _number != 0)
      {}
      else
      {
        Console.WriteLine("Please enter a non-zero number.");
      }
    }

    return _number;
  }
}