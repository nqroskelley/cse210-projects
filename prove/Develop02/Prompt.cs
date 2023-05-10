using System;

public class Prompt
{
  public List<string> _prompts = new List<string>();
  Random random = new Random();
  public int _number;
  public string _prompt;
  
  public void GetPrompt()
  {
    _prompts.Add("What interesting conversations did I have today?");
    _prompts.Add("What was one good thing that happened today?");
    _prompts.Add("Is there anything I wish had gone differently today?");
    _prompts.Add("What was something unexpected that happened today?");
    _prompts.Add("Who did I see today?");
    _number = random.Next(0, 5);
    _prompt = _prompts[_number];

    Console.WriteLine(_prompt);
  }
}