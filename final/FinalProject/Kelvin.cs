using System;

class Kelvin : Temperature
{
  public Kelvin (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("°K");
  }

  public override double ToKelvin()
  {
    throw new NotImplementedException();
  }

  public override double ToCelsius()
  {
    throw new NotImplementedException();
  }

  public override double ToFahrenheit()
  {
    throw new NotImplementedException();
  }
}