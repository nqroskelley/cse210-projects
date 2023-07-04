using System;

abstract class Length : Unit
{
  public Length (string unit, double amount) : base (unit, amount)
  {}

  public abstract double ToInches ();

  public abstract double ToFeet ();

  public abstract double ToYards ();

  public abstract double ToMiles ();

  public abstract double ToMillimeters ();

  public abstract double ToCentimeters ();

  public abstract double ToMeters ();

  public abstract double ToKilometers ();
}