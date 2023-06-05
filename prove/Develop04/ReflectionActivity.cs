using System;

class ReflectionActivity : Activity
{
  private List<string> _prompts;
  private List<string> _questions;

  public ReflectionActivity (string activity, string description) : base (activity, description)
  {
    _prompts = new List<string>();
    _questions = new List<string>();
  }
}