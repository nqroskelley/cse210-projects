using System;

class Meter : Length
{
  public Meter (string unit, double amount) : base (unit, amount)
  {}

  public override double ToInches()
  {
    throw new NotImplementedException();
  }

  public override double ToFeet()
  {
    throw new NotImplementedException();
  }

  public override double ToYards()
  {
    throw new NotImplementedException();
  }

  public override double ToMiles()
  {
    throw new NotImplementedException();
  }

  public override double ToMillimeters()
  {
    throw new NotImplementedException();
  }

  public override double ToCentimeters()
  {
    throw new NotImplementedException();
  }

  public override double ToMeters()
  {
    throw new NotImplementedException();
  }

  public override double ToKilometers()
  {
    throw new NotImplementedException();
  }
}