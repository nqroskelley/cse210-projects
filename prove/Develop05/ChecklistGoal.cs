using System;

class ChecklistGoal : Goal
{
  private int _timesToComplete;
  private int _timesCompleted;
  private int _bonus;

  public ChecklistGoal (string name, string description, int points, int complete, int times, int bonus) : base (name, description, points)
  {
    _timesCompleted = complete;
    _timesToComplete = times;
    _bonus = bonus;
  }

  public override int RecordEvent()
  {
    _timesCompleted++;
    if (_timesCompleted == _timesToComplete)
    {
      return GetPoints() + _bonus;
    }
    else
    {
      return GetPoints();
    }
  }

  public override bool IsComplete()
  {
    if (_timesCompleted >= _timesToComplete)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public override void Display()
  {
    if (IsComplete())
    {
      Console.WriteLine($"[X] {GetName()} ({GetDescription()}) {_timesCompleted}/{_timesToComplete}");
    }
    else
    {
      Console.WriteLine($"[] {GetName()} ({GetDescription()}) {_timesCompleted}/{_timesToComplete}");
    }
  }

  public override string GetStringRepresentation()
  {
    return $"checklist^{GetName()}|{GetDescription()}|{GetPoints()}|{_timesCompleted}|{_timesToComplete}|{_bonus}";
  }
}