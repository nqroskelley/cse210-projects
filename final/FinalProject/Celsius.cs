using System;

class Celsius : Temperature
{
  public Celsius (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("°C");
  }

  public override double ToKelvins()
  {
    return GetAmount() + 273.15;
  }

  public override double ToCelsius()
  {
    return GetAmount();
  }

  public override double ToFahrenheit()
  {
    return (GetAmount() * 1.8) + 32;
  }
}