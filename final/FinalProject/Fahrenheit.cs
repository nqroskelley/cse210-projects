using System;

class Fahrenheit : Temperature
{
  public Fahrenheit (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("°F");
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