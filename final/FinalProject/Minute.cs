using System;

class Minute : Time
{
  public Minute (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("minute");
  }

  public override double ToSeconds()
  {
    return GetAmount() * 60;
  }

  public override double ToMinutes()
  {
    return GetAmount();
  }

  public override double ToHours()
  {
    return GetAmount() / 60;
  }

  public override double ToDays()
  {
    return GetAmount() / 1440;
  }

  public override double ToWeeks()
  {
    return GetAmount() / 10080;
  }

  public override double ToMonths()
  {
    return GetAmount() / 43800;
  }

  public override double ToYears()
  {
    return GetAmount() / 525600;
  }
}