using System;

class Word
{
  private string _word;
  private bool _hidden;
  private int _length;

  public Word(string word)
  {
    _word = word;
    _hidden = false;
    _length = _word.Length;
  }

  public string GetWord()
  {
    return _word;
  }

  public bool GetHidden()
  {
    return _hidden;
  }

  public void Hide()
  {
    _word = "";

    for(int i = 0; i < _length; i++)
    {
      _word = $"{_word}_";
    }
  }
}