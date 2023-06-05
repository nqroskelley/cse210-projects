using System;

class Activity
{
  private int _time;
  private int _countdown;
  private DateTime _start;
  private DateTime _stop;
  private string _activity;
  private string _description;
  private Random _random;

  public Activity (string activity, string description)
  {
    _activity = activity;
    _description = description;
    _random = new Random();
  }
}