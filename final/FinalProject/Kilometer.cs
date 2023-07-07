using System;

class Kilometer : Length
{
  public Kilometer (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("kilometer");
  }

  public override double ToInches()
  {
    return GetAmount() * 39370.1;
  }

  public override double ToFeet()
  {
    return GetAmount() * 3280.84;
  }

  public override double ToYards()
  {
    return GetAmount() * 1093.61;
  }

  public override double ToMiles()
  {
    return GetAmount() / 1.609344;
  }

  public override double ToMillimeters()
  {
    return GetAmount() * 1000000;
  }

  public override double ToCentimeters()
  {
    return GetAmount() * 100000;
  }

  public override double ToMeters()
  {
    return GetAmount() * 1000;
  }

  public override double ToKilometers()
  {
    return GetAmount();
  }
}