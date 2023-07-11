using System;

abstract class Temperature : Unit
{
  public Temperature (string unit, double amount) : base (unit, amount)
  {
    if (unit == "1")
    {
      SetUnit2("K");
      SetResult(ToKelvins());
    }
    if (unit == "2")
    {
      SetUnit2("°C");
      SetResult(ToCelsius());
    }
    if (unit == "3")
    {
      SetUnit2("°F");
      SetResult(ToFahrenheit());
    }
  }

  public abstract double ToKelvins ();

  public abstract double ToCelsius ();

  public abstract double ToFahrenheit ();
}