using System;

class Gram : Mass
{
  public Gram (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("gram");
  }

  public override double ToOunces()
  {
    return GetAmount() / 28.3495;
  }

  public override double ToPounds()
  {
    return GetAmount() / 453.592;
  }

  public override double ToTons()
  {
    return GetAmount() / 907185;
  }

  public override double ToMilligrams()
  {
    return GetAmount() * 1000;
  }

  public override double ToGrams()
  {
    return GetAmount();
  }

  public override double ToKilograms()
  {
    return GetAmount() / 1000;
  }
}