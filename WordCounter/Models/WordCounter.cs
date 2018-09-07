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
    //Sets parameters for RepeatCounter
    {
      _word = word;
      _sentence = sentence;
    }
    public void SetWord(string inputWord)
    //Setter for word
    {
      _word = inputWord;
    }
    public string GetWord()
    //Getter for word
    {
      return _word;
    }
    public void SetSentence(string sentenceInput)
    //Setter for sentence
    {
      _sentence = sentenceInput;
    }
    public string GetSentence()
    //Getter for sentence
    {
      return _sentence;
    }
    public string[] SplitSentence()
    //Splits the sentence into individual arrays and returns itself
    {
      string[] newArray = _sentence.Split(' ');
      return newArray;
    }
    public int Count()
    //Splits the sentence into an array, loops through the array. if the _word is equal to the index[i] of the loop at that instance, add the conditional statement. ? is a conditional statement that adds 1 if true(same), or 0 if false (not the same). adds the word count (1/0) to the global _count
    {
      string [] newArray = SplitSentence();
      for(int i = 0 ; i < newArray.Length - 1; i++)
      {
        _count +=(_word == newArray[i]) ? 1 : 0;
      }
      return _count;
    }
  }
}
