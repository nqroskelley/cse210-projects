using System;

class Meter : Length
{
  public Meter (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("meter");
  }

  public override double ToInches()
  {
    return GetAmount() * 39.3701;
  }

  public override double ToFeet()
  {
    return GetAmount() * 3.28084;
  }

  public override double ToYards()
  {
    return GetAmount() * 1.09361;
  }

  public override double ToMiles()
  {
    return GetAmount() / 1609.344;
  }

  public override double ToMillimeters()
  {
    return GetAmount() * 1000;
  }

  public override double ToCentimeters()
  {
    return GetAmount() * 100;
  }

  public override double ToMeters()
  {
    return GetAmount();
  }

  public override double ToKilometers()
  {
    return GetAmount() / 1000;
  }
}