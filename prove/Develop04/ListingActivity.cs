using System;

class ListingActivity : Activity
{
  private int _answers;
  private int _total;

  public ListingActivity (string activity, string description) : base (activity, description)
  {
    GetQuestions().Add("What are some of your favorite hobbies?");
    GetQuestions().Add("Who are some of your closest friends?");
    GetQuestions().Add("What are some things that you are good at?");
    GetQuestions().Add("What are some spiritual experiences that you have had?");
    GetQuestions().Add("What are some of your greatest achievements?");
    GetQuestions().Add("What are some of your favorite foods?");
    _total = 0;
  }

  public void List ()
  {
    _answers = 0;
    Console.WriteLine("List as many answers to the following question as you can:");
    Console.WriteLine("");
    Console.WriteLine($"--- {GetQuestions()[GetRandom().Next(0, 6)]} ---");
    Console.WriteLine("");
    Console.Write("Starting in: ");
    Countdown();
    SetTimer(DateTime.Now);

    while (DateTime.Now < GetStop())
    {
      Console.Write(">");
      Console.ReadLine();
      _answers++;
    }

    _total = _total + _answers;
    Console.WriteLine("");
    Console.WriteLine($"You counted {_answers} of your blessings!");
    Pause(3);
    Console.WriteLine($"You've counted a total of {_total} blessings!");
    Pause(3);
  }
}