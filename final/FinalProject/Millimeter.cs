using System;

class Millimeter : Length
{
  public Millimeter (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("millimeter");
  }

  public override double ToInches()
  {
    return GetAmount() / 25.4;
  }

  public override double ToFeet()
  {
    return GetAmount() / 304.8;
  }

  public override double ToYards()
  {
    return GetAmount() / 914.4;
  }

  public override double ToMiles()
  {
    return GetAmount() / 1609344;
  }

  public override double ToMillimeters()
  {
    return GetAmount();
  }

  public override double ToCentimeters()
  {
    return GetAmount() / 10;
  }

  public override double ToMeters()
  {
    return GetAmount() / 1000;
  }

  public override double ToKilometers()
  {
    return GetAmount() / 1000000;
  }
}