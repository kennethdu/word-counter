using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;
    private int _count = 0;
    public RepeatCounter (string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }
    public void SetWord(string inputWord)
    {
      _word = inputWord;
    }
    public string GetWord()
    {
      return _word;
    }
    public void SetSentence(string sentenceInput)
    {
      _sentence = sentenceInput;
    }
    public string GetSentence()
    {
      return _sentence;
    }
    public string[] SplitSentence()
    {
      string[] newArray = _sentence.Split(' ');
      return newArray;
    }
    public int Compare()
    {
      string [] newArray = SplitSentence();
      for(int i = 0 ; i < newArray.Length - 1; i++)
      {
        if(newArray[i] == _word)
        {
          _count++;
        }
        else
        {
          return _count;
        }
      }
      return _count;
    }
  }
}
