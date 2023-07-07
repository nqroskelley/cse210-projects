using System;

class Milligram : Mass
{
  public Milligram (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("milligram");
  }

  public override double ToOunces()
  {
    return GetAmount() / 28349.523125;
  }

  public override double ToPounds()
  {
    return GetAmount() / 453592.37;
  }

  public override double ToTons()
  {
    return GetAmount() / 907184740;
  }

  public override double ToMilligrams()
  {
    return GetAmount();
  }

  public override double ToGrams()
  {
    return GetAmount() / 1000;
  }

  public override double ToKilograms()
  {
    return GetAmount() / 1000000;
  }
}