using System;

class Year : Time
{
  public Year (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("year");    
  }

  public override double ToSeconds()
  {
    return GetAmount() * 31536000;
  }

  public override double ToMinutes()
  {
    return GetAmount() * 525600;
  }

  public override double ToHours()
  {
    return GetAmount() * 8760;
  }

  public override double ToDays()
  {
    return GetAmount() * 365;
  }

  public override double ToWeeks()
  {
    return GetAmount() * 52.1429;
  }

  public override double ToMonths()
  {
    return GetAmount() * 12;
  }

  public override double ToYears()
  {
    return GetAmount();
  }
}