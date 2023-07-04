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
    Console.WriteLine($"{_amount} {_unit1} equals {_result} {_unit2}.");
  }
}