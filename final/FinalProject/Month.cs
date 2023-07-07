using System;

class Month : Time
{
  public Month (string unit, double amount) : base (unit, amount)
  {
    SetUnit1("month");
  }

  public override double ToSeconds()
  {
    return GetAmount() * 2628002.88;
  }

  public override double ToMinutes()
  {
    return GetAmount() * 43800.048;
  }

  public override double ToHours()
  {
    return GetAmount() * 730.0008;
  }

  public override double ToDays()
  {
    return GetAmount() * 30.4167;
  }

  public override double ToWeeks()
  {
    return GetAmount() * 4.34524;
  }

  public override double ToMonths()
  {
    return GetAmount();
  }

  public override double ToYears()
  {
    return GetAmount() / 12;
  }
}