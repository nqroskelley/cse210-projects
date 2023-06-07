using System;

class BreathingActivity : Activity
{
  public BreathingActivity (string activity, string description) : base (activity, description)
  {}

  public void Breathe()
  {
    while (DateTime.Now < GetStop())
    {
      Console.Write("Inhale... ");
      Countdown();
      Console.Write("Exhale... ");
      Countdown();
    }
  }
}