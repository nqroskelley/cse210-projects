using System;

class Scripture
{
  private List<Word> _words = new List<Word>();
  private string _reference;
  private string[] _splitVerse;
  private Word _word;
  private Random _random = new Random();
  private int _count;
  private int _number;

  public Scripture(string reference, string verse)
  {
    _reference = reference;
    _splitVerse = verse.Split(' ');

    foreach(string word in _splitVerse)
    {
      _word = new Word(word);
      _words.Add(_word);
    }

    _count = _words.Count;
  }

  public void Display()
  {
    Console.Clear();
    Console.WriteLine(_reference);
    foreach(Word word in _words)
    {
      Console.Write($"{word.GetWord()} ");
    }
    Console.WriteLine("");
  }

  public string HideWords()
  {
    if(_words.Exists(word => word.GetHidden() == false))
    {
      for(int i = 0; i < 3; i++)
      {
        _number = _random.Next(0, _count);
        _words[_number].Hide();
      }

      return "";
    }
    else
    {
      return "quit";
    }
  }
}