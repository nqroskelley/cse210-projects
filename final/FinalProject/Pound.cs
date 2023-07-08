using System;

class Pound : Mass
{
  public Pound (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("pound");
  }

  public override double ToOunces()
  {
    return GetAmount() * 16;
  }

  public override double ToPounds()
  {
    return GetAmount();
  }

  public override double ToTons()
  {
    return GetAmount() / 2000;
  }

  public override double ToMilligrams()
  {
    return GetAmount() * 453592.37;
  }

  public override double ToGrams()
  {
    return GetAmount() * 453.59237;
  }

  public override double ToKilograms()
  {
    return GetAmount() / 2.20462;
  }
}