using System;

class Inch : Length
{
  public Inch (string unit, double amount) : base (unit, amount)
  {
    if (amount == 1)
    {
      SetUnit1("inch");
    }
    else
    {
      SetUnit1("inches");
    }
  }

  public override double ToInches()
  {
    return GetAmount();
  }

  public override double ToFeet()
  {
    return GetAmount() / 12;
  }

  public override double ToYards()
  {
    return GetAmount() / 36;
  }

  public override double ToMiles()
  {
    return GetAmount() / 63360;
  }

  public override double ToMillimeters()
  {
    return GetAmount() * 25.4;
  }

  public override double ToCentimeters()
  {
    return GetAmount() * 2.54;
  }

  public override double ToMeters()
  {
    return GetAmount() / 39.3701;
  }

  public override double ToKilometers()
  {
    return GetAmount() / 39370.1;
  }
}