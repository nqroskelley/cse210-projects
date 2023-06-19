using System;

class ChecklistGoal : Goal
{
  private int _timesToComplete;
  private int _timesCompleted;
  private int _bonus;

  public ChecklistGoal (string name, string description, int points, int times, int bonus) : base (name, description, points)
  {
    _timesToComplete = times;
    _bonus = bonus;
  }
}