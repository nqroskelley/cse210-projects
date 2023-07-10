using System;

class Unit
{
  private string _unit1;
  private string _unit2;
  private double _amount;
  private double _result;

  public Unit (string unit, double amount)
  {
    _unit2 = unit;
    _amount = amount;
  }

  public string GetUnit2 ()
  {
    return _unit2;
  }

  public double GetAmount ()
  {
    return _amount;
  }

  public void SetUnit1 (string unit)
  {
    _unit1 = unit;
  }

  public void SetUnit2 (string unit)
  {
    _unit2 = unit;
  }

  public void SetResult (double result)
  {
    _result = result;
  }

  public void DisplayResult ()
  {
    if (_amount != 1 && _unit1 != "inches" && _unit1 != "feet" && _unit1.Contains("°") == false)
    {
      _unit1 = _unit1 + "s";
    }

    if (_result != 1 && _unit2 != "inches" && _unit2 != "feet" && _unit1.Contains("°") == false)
    {
      _unit2 = _unit2 + "s";
    }

    Console.Clear();

    Console.WriteLine($"{_amount} {_unit1} = {_result} {_unit2}.");
  }
}