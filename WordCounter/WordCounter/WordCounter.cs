using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class Word
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
