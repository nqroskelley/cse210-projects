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
        Console.WriteLine("");
        Console.Write("Get ready... ");
        Countdown();
      }
      else
      {
        Console.Write("Please enter a number greater than 0: ");
      }
    }

    _start = DateTime.Now;
    _stop = _start.AddSeconds(_time);

    Console.Clear();
  }
  
  public void Countdown ()
  {
    _countdown = 5;

    while (_countdown > 0)
    {
      Console.Write($"{_countdown}");
      Thread.Sleep(1000);
      _countdown--;
      Console.Write("\b \b");
    }
    Console.WriteLine("");
  }

  public void Pause (int pause)
  {
    for (int i = pause; i > 0; i--)
    {
      Console.Write("|");
      Thread.Sleep(250);
      Console.Write("\b \b");
      Console.Write("/");
      Thread.Sleep(250);
      Console.Write("\b \b");
      Console.Write("-");
      Thread.Sleep(250);
      Console.Write("\b \b");
      Console.Write("\\");
      Thread.Sleep(250);
      Console.Write("\b \b");
    }
  }

  public void End ()
  {
    Console.WriteLine($"Great Job, You did the {_activity} activity for {_time} seconds!");
    Pause(5);
    Console.Clear();
  }
}