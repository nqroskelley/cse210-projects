using System;

class Hour : Time
{
  public Hour (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("hour");
  }

  public override double ToSeconds()
  {
    return GetAmount() * 3600;
  }

  public override double ToMinutes()
  {
    return GetAmount() * 60;
  }

  public override double ToHours()
  {
    return GetAmount();
  }

  public override double ToDays()
  {
    return GetAmount() / 24;
  }

  public override double ToWeeks()
  {
    return GetAmount() / 168;
  }

  public override double ToMonths()
  {
    return GetAmount() / 730.001;
  }

  public override double ToYears()
  {
    return GetAmount() / 8760;
  }
}