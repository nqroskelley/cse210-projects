using System;

class Celsius : Temperature
{
  public Celsius (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("°C");
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