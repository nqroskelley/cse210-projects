using System;

class Mile : Length
{
  public Mile (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("mile");
  }

  public override double ToInches()
  {
    return GetAmount() * 63360;
  }

  public override double ToFeet()
  {
    return GetAmount() * 5280;
  }

  public override double ToYards()
  {
    return GetAmount() * 1760;
  }

  public override double ToMiles()
  {
    return GetAmount();
  }

  public override double ToMillimeters()
  {
    return GetAmount() * 1609344;
  }

  public override double ToCentimeters()
  {
    return GetAmount() * 160934.4;
  }

  public override double ToMeters()
  {
    return GetAmount() * 1609.344;
  }

  public override double ToKilometers()
  {
    return GetAmount() * 1.609344;
  }
}