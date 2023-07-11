using System;

class Fahrenheit : Temperature
{
  public Fahrenheit (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("°F");
  }

  public override double ToKelvin()
  {
    return ((GetAmount() -32) / 1.8) + 273.15;
  }

  public override double ToCelsius()
  {
    return (GetAmount() - 32) / 1.8;
  }

  public override double ToFahrenheit()
  {
    return GetAmount();
  }
}