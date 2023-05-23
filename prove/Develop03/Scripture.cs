using System;

class Scripture
{
  private List<Word> _words = new List<Word>();
  private string _reference;
  private string[] _splitVerse;
  private Word _word;

  public Scripture(string reference, string verse)
  {
    _reference = reference;
    _splitVerse = verse.Split(' ');

    foreach(string word in _splitVerse)
    {
      _word = new Word(word);
      _words.Add(_word);
    }
  }
}