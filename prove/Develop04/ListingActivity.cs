using System;

class ListingActivity : Activity
{
  private List<string> _questions;
  private int _answers;

  public ListingActivity (string activity, string description) : base (activity, description)
  {
    _questions = new List<string>();
    _answers = 0;
  }
}