using System;

class ReflectionActivity : Activity
{
  private List<string> _prompts;

  public ReflectionActivity (string activity, string description) : base (activity, description)
  {
    _prompts = new List<string>();
    _prompts.Add("Think of a time when you chose to do the right thing, even though it was hard.");
    _prompts.Add("Think of a time when you overcame a difficult trial.");
    _prompts.Add("Think of a time when you comforted someone.");
    _prompts.Add("Think of a time when you willingly gave service to someone.");
    GetQuestions().Add("What did you learn from this experience?");
    GetQuestions().Add("How did this experience make you feel?");
    GetQuestions().Add("If something like this happens again, what will you do differently?");
    GetQuestions().Add("What other situations could having this experience be helpful with?");
    GetQuestions().Add("What was something that stood out to you about this experience?");
    GetQuestions().Add("How did this experience begin?");
    GetQuestions().Add("How did this experience end?");
    GetQuestions().Add("How did this experience affect you personally?");
    GetQuestions().Add("What is something that you remember fondly about this experience?");
  }

  public void Reflect ()
  {
    Console.WriteLine($"--- {_prompts[GetRandom().Next(0, 4)]} ---");
    Console.WriteLine("");
    Console.WriteLine("When you are ready, press enter.");
    Console.ReadLine();
    SetTimer(DateTime.Now);

    while (DateTime.Now < GetStop())
    {
      Console.Write(GetQuestions()[GetRandom().Next(0, 9)]);
      Pause(10);
      Console.WriteLine("");
    }
  }
}