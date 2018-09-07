using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    public Word (string word)
    {
      _word = word;
    }
    public void SetWord(string input)
    {
      _word = input;
    }
    public string GetWord()
    {
      return _word;
    }
  }
}
