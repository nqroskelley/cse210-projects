using System;

class Year : Time
{
  public Year (string unit, double amount) : base (unit, amount)
  {}

  public override double ToSeconds()
  {
    throw new NotImplementedException();
  }

  public override double ToMinutes()
  {
    throw new NotImplementedException();
  }

  public override double ToHours()
  {
    throw new NotImplementedException();
  }

  public override double ToDays()
  {
    throw new NotImplementedException();
  }

  public override double ToWeeks()
  {
    throw new NotImplementedException();
  }

  public override double ToMonths()
  {
    throw new NotImplementedException();
  }

  public override double ToYears()
  {
    throw new NotImplementedException();
  }
}