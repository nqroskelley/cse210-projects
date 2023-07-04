using System;

abstract class Mass : Unit
{
  public Mass (string unit, double amount) : base (unit, amount)
  {}

  public abstract double ToOunces ();

  public abstract double ToPounds ();

  public abstract double ToTons ();

  public abstract double ToMilligrams ();

  public abstract double ToGrams ();

  public abstract double ToKilograms ();
}