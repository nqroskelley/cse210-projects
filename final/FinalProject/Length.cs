using System;

abstract class Length : Unit
{
  public Length (string unit, double amount) : base (unit, amount)
  {
    if (unit == "1")
    {
      if (ToInches() == 1)
      {
        SetUnit2("inch");
      }
      else
      {
        SetUnit2("inches");
      }

      SetResult(ToInches());
    }
    else if (unit == "2")
    {
      if (ToFeet() == 1)
      {
        SetUnit2("foot");
      }
      else
      {
        SetUnit2("feet");
      }

      SetResult(ToFeet());
    }
    else if (unit == "3")
    {
      SetUnit2("yard");
      SetResult(ToYards());
    }
    else if (unit == "4")
    {
      SetUnit2("mile");
      SetResult(ToMiles());
    }
    else if (unit == "5")
    {
      SetUnit2("millimeter");
      SetResult(ToMillimeters());
    }
    else if (unit == "6")
    {
      SetUnit2("centimeter");
      SetResult(ToCentimeters());
    }
    else if (unit == "7")
    {
      SetUnit2("meter");
      SetResult(ToMeters());
    }
    else if (unit == "8")
    {
      SetUnit2("kilometer");
      SetResult(ToKilometers());
    }
  }

  public abstract double ToInches ();

  public abstract double ToFeet ();

  public abstract double ToYards ();

  public abstract double ToMiles ();

  public abstract double ToMillimeters ();

  public abstract double ToCentimeters ();

  public abstract double ToMeters ();

  public abstract double ToKilometers ();
}