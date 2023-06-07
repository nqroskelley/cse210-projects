using System;

class ReflectionActivity : Activity
{
  private List<string> _prompts;

  public ReflectionActivity (string activity, string description) : base (activity, description)
  {
    _prompts = new List<string>();
  }
}