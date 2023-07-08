using System;

class Ton : Mass
{
  public Ton (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("ton");
  }

  public override double ToOunces()
  {
    return GetAmount() * 32000;
  }

  public override double ToPounds()
  {
    return GetAmount() * 2000;
  }

  public override double ToTons()
  {
    return GetAmount();
  }

  public override double ToMilligrams()
  {
    return GetAmount() * 907184740;
  }

  public override double ToGrams()
  {
    return GetAmount() * 907184.74;
  }

  public override double ToKilograms()
  {
    return GetAmount() * 907.18474;
  }
}