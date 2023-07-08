using System;

class Yard : Length
{
  public Yard (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("yard");
  }

  public override double ToInches()
  {
    return GetAmount() * 36;
  }

  public override double ToFeet()
  {
    return GetAmount() * 3;
  }

  public override double ToYards()
  {
    return GetAmount();
  }

  public override double ToMiles()
  {
    return GetAmount() / 1760;
  }

  public override double ToMillimeters()
  {
    return GetAmount() * 914.4;
  }

  public override double ToCentimeters()
  {
    return GetAmount() * 91.44;
  }

  public override double ToMeters()
  {
    return GetAmount() / 1.09361;
  }

  public override double ToKilometers()
  {
    return GetAmount() / 1093.61;
  }
}