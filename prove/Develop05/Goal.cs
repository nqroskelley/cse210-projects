using System;

class Goal
{
  private string _name;
  private string _description;
  private int _points;
  private bool _complete;

  public Goal (string name, string description, int points)
  {
    _name = name;
    _description = description;
    _points = points;
    _complete = false;
  }
}