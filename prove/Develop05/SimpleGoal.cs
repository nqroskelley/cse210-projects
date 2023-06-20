using System;

class SimpleGoal : Goal
{
  private bool _complete;

  public SimpleGoal (string name, string description, int points) : base (name, description, points)
  {
    _complete = false;
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
    throw new NotImplementedException();
  }
}