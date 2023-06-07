using System;

class ListingActivity : Activity
{
  private int _answers;

  public ListingActivity (string activity, string description) : base (activity, description)
  {
    _answers = 0;
  }
}