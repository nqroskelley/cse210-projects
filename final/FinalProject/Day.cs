using System;

class Day : Time
{
  public Day (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("day");
  }

  public override double ToSeconds()
  {
    return GetAmount() * 86400;
  }

  public override double ToMinutes()
  {
    return GetAmount() * 1440;
  }

  public override double ToHours()
  {
    return GetAmount() * 24;
  }

  public override double ToDays()
  {
    return GetAmount();
  }

  public override double ToWeeks()
  {
    return GetAmount() / 7;
  }

  public override double ToMonths()
  {
    return GetAmount() / 30.4167;
  }

  public override double ToYears()
  {
    return GetAmount() / 365;
  }
}