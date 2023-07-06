using System;

class Foot : Length
{
  public Foot (string unit, double amount) : base (unit, amount)
  {
    if (amount == 1)
    {
      SetUnit1("foot");
    }
    else
    {
      SetUnit1("feet");
    }
  }

  public override double ToInches()
  {
    return GetAmount() * 12;
  }

  public override double ToFeet()
  {
    return GetAmount();
  }

  public override double ToYards()
  {
    return GetAmount() / 3;
  }

  public override double ToMiles()
  {
    return GetAmount() / 5280;
  }

  public override double ToMillimeters()
  {
    return GetAmount() * 304.8;
  }

  public override double ToCentimeters()
  {
    return GetAmount() * 30.48;
  }

  public override double ToMeters()
  {
    return GetAmount() / 3.28084;
  }

  public override double ToKilometers()
  {
    return GetAmount() / 3280.84;
  }
}