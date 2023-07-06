using System;

class Centimeter : Length
{
  public Centimeter (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("centimeter");
  }

  public override double ToInches()
  {
    return GetAmount() / 2.54;
  }

  public override double ToFeet()
  {
    return GetAmount() / 30.48;
  }

  public override double ToYards()
  {
    return GetAmount() / 91.44;
  }

  public override double ToMiles()
  {
    return GetAmount() / 160934.4;
  }

  public override double ToMillimeters()
  {
    return GetAmount() * 10;
  }

  public override double ToCentimeters()
  {
    return GetAmount();
  }

  public override double ToMeters()
  {
    return GetAmount() / 100;
  }

  public override double ToKilometers()
  {
    return GetAmount() / 100000;
  }
}