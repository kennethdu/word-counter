using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void GetWord_ReturnUserWord_String()
    {
      //Arrange
      RepeatCounter userInput = new RepeatCounter("dog", "my dog is the best dog");
      //Act
      string word = userInput.GetWord();
      //Assert
      Assert.AreEqual("dog", word);
    }
    [TestMethod]
    public void GetSentence_ReturnUserSentence_String()
    {
      //Arrange
      RepeatCounter userInput = new RepeatCounter("dog", "my dog is the best dog");
      //Act
      string sentence = userInput.GetSentence();
      //Assert
      Assert.AreEqual("my dog is the best dog", sentence);
    }
    [TestMethod]
    public void SplitSentence_SplitUserSentence_String()
    {
      //Arrange
      RepeatCounter userInput = new RepeatCounter("dog", "my dog is the best dog");
      //Act
      string[] splitSentence = userInput.SplitSentence();
      //Assert
      Assert.AreEqual("my", splitSentence[0]);
    }
    [TestMethod]
    public void CountWord_CheckIfWordAppearsInSentence_Int()
    {
      //Arrange
      RepeatCounter userInput = new RepeatCounter("dog", "my dog is the best dog ");
      //Act
      int wordCount = userInput.CountWord();
      //Assert
      Assert.AreEqual(2, wordCount);
    }
  }
}
