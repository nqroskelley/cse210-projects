using System;

abstract class Time : Unit
{
  public Time (string unit, double amount) : base (unit, amount)
  {}

  public abstract double ToSeconds ();

  public abstract double ToMinutes ();

  public abstract double ToHours ();

  public abstract double ToDays ();

  public abstract double ToWeeks ();

  public abstract double ToMonths ();

  public abstract double ToYears ();
}