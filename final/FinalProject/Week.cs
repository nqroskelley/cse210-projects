using System;

class Week : Time
{
  public Week (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("week");
  }

  public override double ToSeconds()
  {
    return GetAmount() * 604800;
  }

  public override double ToMinutes()
  {
    return GetAmount() * 10080;
  }

  public override double ToHours()
  {
    return GetAmount() * 168;
  }

  public override double ToDays()
  {
    return GetAmount() * 7;
  }

  public override double ToWeeks()
  {
    return GetAmount();
  }

  public override double ToMonths()
  {
    return GetAmount() / 4.34524;
  }

  public override double ToYears()
  {
    return GetAmount() / 52.1429;
  }
}