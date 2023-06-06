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

  public DateTime GetStart ()
  {
    return _start;
  }

  public DateTime GetStop ()
  {
    return _stop;
  }

  public Random GetRandom ()
  {
    return _random;
  }

  public void Begin ()
  {
    Console.Clear();
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
      {
        Countdown();
      }
      else
      {
        Console.Write("Please enter a number greater than 0: ");
      }
    }

    _start = DateTime.Now;
    _stop = _start.AddSeconds(_time);

    Console.WriteLine("");
  }
  
  public void Countdown ()
  {
    Console.WriteLine("");
    _countdown = 5;
    Console.Write("Get ready... ");
    while (_countdown > 0)
    {
      Console.Write($"{_countdown}");
      Thread.Sleep(1000);
      _countdown--;
      Console.Write("\b \b");
    }
    Console.WriteLine("");
  }

  public void End ()
  {
    Console.WriteLine($"Great Job, You did the {_activity} activity for {_time} seconds!");
    Thread.Sleep(5000);
    Console.Clear();
  }
}