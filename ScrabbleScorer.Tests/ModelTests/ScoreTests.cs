using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ValueTests
  {
    [TestMethod]
  public void Main_WillReturnValue_Int()
  {
    //Arrange
    string letter = "A";
    int value = 1;
    //Act
    Score Ben = new Score(letter, value);
   

    //Assert
    Assert.AreEqual(letter, value);
  }
  }
}