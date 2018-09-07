using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class Word()
  {
    [TestMethod]
    publid void GetWord_ReturnUserWord_String()
    {
      //Arrange
      string word = "hello";
      Word newWord = new Word(word);
      //Act
      string result = newWord.GetWord();
      //Assert
      Assert.AreEqual("hello", result);
    }
    // [TestMethod]
    // publid void GetSentence_ReturnUserSentence_String()
    // {
    //   //Arrange
    //   //Act
    //   //Assert
    // }
    // [TestMethod]
    // publid void SplitSentence_SplitUserSentence_String()
    // {
    //   //Arrange
    //   //Act
    //   //Assert
    // }
    // [TestMethod]
    // publid void Compare_CheckIfWordAppearsInSentence_bool()
    // {
    //   //Arrange
    //   //Act
    //   //Assert
    // }
    // [TestMethod]
    // publid void Count_Add1toWordCount_Int()
    // {
    //   //Arrange
    //   //Act
    //   //Assert
    // }
  }
}
