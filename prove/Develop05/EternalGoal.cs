using System;

class EternalGoal : Goal
{
  public EternalGoal (string name, string description, int points) : base (name, description, points)
  {}

  public override int RecordEvent()
  {
    return GetPoints();
  }

  public override bool IsComplete()
  {
    return false;
  }

  public override void Display()
  {
    Console.WriteLine($"[] {GetName()} ({GetDescription()})");
  }

  public override string GetStringRepresentation()
  {
    return $"eternal^{GetName()}|{GetDescription()}|{GetPoints()}";
  }
}