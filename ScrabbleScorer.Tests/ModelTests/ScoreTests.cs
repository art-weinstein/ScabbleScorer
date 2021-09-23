using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ValueTests
  {
    [TestMethod]
  public void Dictionary_InitializesValuesCorrectly()
    {
      Dictionary<string, int> letters = new Dictionary<string, int>(){{"b", 3}, {"e", 1}, {"n", 1}};
      Assert.AreEqual(3, letters["b"]);
      Assert.AreEqual(1, letters["e"]);
      Assert.AreEqual(1, letters["n"]);
    }
      [TestMethod]
    public void IsASplitArray_TakesInAWord_SplitsIntoCharArrays()
    {
      //Arrange
      string userInput = "ben";
      //Act
      Dictionary<string, int> letters = new Dictionary<string, int>() {{"b", 3}, {"e", 1}, {"n", 1}};
      //Assert
      Assert.AreEqual(3, letters["b"]);
      Assert.AreEqual(1, letters["e"]);
      Assert.AreEqual(1, letters["n"]);
    }
  }
}