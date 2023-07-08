using System;

class Second : Time
{
  public Second (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("second");
  }

  public override double ToSeconds()
  {
    return GetAmount();
  }

  public override double ToMinutes()
  {
    return GetAmount() / 60;
  }

  public override double ToHours()
  {
    return GetAmount() / 3600;
  }

  public override double ToDays()
  {
    return GetAmount() / 86400;
  }

  public override double ToWeeks()
  {
    return GetAmount() / 604800;
  }

  public override double ToMonths()
  {
    return GetAmount() / 2628002.88;
  }

  public override double ToYears()
  {
    return GetAmount() / 31536000;
  }
}