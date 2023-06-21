using System;

class SimpleGoal : Goal
{
  private bool _complete;

  public SimpleGoal (string name, string description, int points, bool complete) : base (name, description, points)
  {
    _complete = complete;
  }

  public override int RecordEvent ()
  {
    _complete = true;
    return GetPoints();
  }

  public override bool IsComplete()
  {
    return _complete;
  }

  public override void Display()
  {
    if (IsComplete())
    {
      Console.WriteLine($"[X] {GetName()} ({GetDescription()})");
    }
    else
    {
      Console.WriteLine($"[] {GetName()} ({GetDescription()})");
    }
  }

  public override string GetStringRepresentation()
  {
    return $"simple^{GetName()}|{GetDescription()}|{GetPoints()}|{_complete}";
  }
}