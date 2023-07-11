using System;

class Kelvin : Temperature
{
  public Kelvin (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("°K");
  }

  public override double ToKelvin()
  {
    return GetAmount();
  }

  public override double ToCelsius()
  {
    return GetAmount() - 273.15;
  }

  public override double ToFahrenheit()
  {
    return ((GetAmount() - 273.15) * 1.8) + 32;
  }
}