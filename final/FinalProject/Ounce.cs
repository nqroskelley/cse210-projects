using System;

class Ounce : Mass
{
  public Ounce (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("ounce");
  }

  public override double ToOunces()
  {
    return GetAmount();
  }

  public override double ToPounds()
  {
    return GetAmount() / 16;
  }

  public override double ToTons()
  {
    return GetAmount() / 32000;
  }

  public override double ToMilligrams()
  {
    return GetAmount() * 28349.523125;
  }

  public override double ToGrams()
  {
    return GetAmount() * 28.349523125;
  }

  public override double ToKilograms()
  {
    return GetAmount() / 35.274;
  }
}