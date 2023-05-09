using System;

public class Prompt
{
  public List<string> _prompts = new List<string>();
  Random random = new Random();
  public int number;
  
  public void GetPrompt()
  {
    _prompts.Add("What was the most interesting conversation I had today?");
    _prompts.Add("What was one good thing that happened today?");
    _prompts.Add("Is there anything I wish had gone differently today?");
    _prompts.Add("What was something unexpected that happened today?");
    _prompts.Add("Who did I see today?");
    number = random.Next(0, 5);

    Console.WriteLine(_prompts[number]);
  }
}