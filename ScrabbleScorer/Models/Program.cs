using System;
using System.Collections.Generic;
using ScrabbleScorer.Models;

namespace ScrabbleScorer 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a letter:");
      string letter = Console.ReadLine();
      int value = 1;

     
      // if (letter == "A"){
      //  int value = 1;
      // }
      Score Ben = new Score(letter, value);
    }
  }
}