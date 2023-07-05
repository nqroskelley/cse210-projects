using System;

class Ton : Mass
{
  public Ton (string unit, double amount) : base (unit, amount)
  {}

  public override double ToOunces()
  {
    throw new NotImplementedException();
  }

  public override double ToPounds()
  {
    throw new NotImplementedException();
  }

  public override double ToTons()
  {
    throw new NotImplementedException();
  }

  public override double ToMilligrams()
  {
    throw new NotImplementedException();
  }

  public override double ToGrams()
  {
    throw new NotImplementedException();
  }

  public override double ToKilograms()
  {
    throw new NotImplementedException();
  }
}