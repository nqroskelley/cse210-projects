using System;

abstract class Time : Unit
{
  public Time (string unit, double amount) : base (unit, amount)
  {
    if (unit == "1")
    {
      SetUnit2("second");
      SetResult(ToSeconds());
    }
    else if (unit == "2")
    {
      SetUnit2("minute");
      SetResult(ToMinutes());
    }
    else if (unit == "3")
    {
      SetUnit2("hour");
      SetResult(ToHours());
    }
    else if (unit == "4")
    {
      SetUnit2("day");
      SetResult(ToDays());
    }
    else if (unit == "5")
    {
      SetUnit2("week");
      SetResult(ToWeeks());
    }
    else if (unit == "6")
    {
      SetUnit2("month");
      SetResult(ToMonths());
    }
    else if (unit == "7")
    {
      SetUnit2("year");
      SetResult(ToYears());
    }
  }

  public abstract double ToSeconds ();

  public abstract double ToMinutes ();

  public abstract double ToHours ();

  public abstract double ToDays ();

  public abstract double ToWeeks ();

  public abstract double ToMonths ();

  public abstract double ToYears ();
}