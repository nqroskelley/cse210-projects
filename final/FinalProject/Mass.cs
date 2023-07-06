using System;

abstract class Mass : Unit
{
  public Mass (string unit, double amount) : base (unit, amount)
  {
    if (unit == "1")
    {
      SetUnit2("ounce");
      SetResult(ToOunces());
    }
    else if (unit == "2")
    {
      SetUnit2("pound");
      SetResult(ToPounds());
    }
    else if (unit == "3")
    {
      SetUnit2("ton");
      SetResult(ToTons());
    }
    else if (unit == "4")
    {
      SetUnit2("milligram");
      SetResult(ToMilligrams());
    }
    else if (unit == "5")
    {
      SetUnit2("gram");
      SetResult(ToGrams());
    }
    else if (unit == "6")
    {
      SetUnit2("kilogram");
      SetResult(ToKilograms());
    }
  }

  public abstract double ToOunces ();

  public abstract double ToPounds ();

  public abstract double ToTons ();

  public abstract double ToMilligrams ();

  public abstract double ToGrams ();

  public abstract double ToKilograms ();
}