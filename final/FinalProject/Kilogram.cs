using System;

class Kilogram : Mass
{
  public Kilogram (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("kilogram");
  }

  public override double ToOunces()
  {
    return GetAmount() * 35.274;
  }

  public override double ToPounds()
  {
    return GetAmount() * 2.20462;
  }

  public override double ToTons()
  {
    return GetAmount() / 907.185;
  }

  public override double ToMilligrams()
  {
    return GetAmount() * 1000000;
  }

  public override double ToGrams()
  {
    return GetAmount() * 1000;
  }

  public override double ToKilograms()
  {
    return GetAmount();
  }
}