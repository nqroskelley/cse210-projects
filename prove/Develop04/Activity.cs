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
  private string _timeString;

  public Activity (string activity, string description)
  {
    _activity = activity;
    _description = description;
    _random = new Random();
  }

  public void Begin ()
  {
    Console.WriteLine($"Welcome to the {_activity} activity!");
    Console.WriteLine("");
    Console.WriteLine(_description);
    Console.WriteLine("");
    Console.Write("How long (in seconds) would you like to do this activity for? ");

    _time = 0;

    while (_time <= 0)
    {
      _timeString = Console.ReadLine();

      if (Int32.TryParse(_timeString, out _time) && _time > 0)
      {}
      else
      {
        Console.Write("Please enter a number greater than 0: ");
      }
    }
  }
}