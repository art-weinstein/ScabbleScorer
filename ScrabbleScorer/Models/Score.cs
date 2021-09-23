namespace ScrabbleScorer.Models
{
  public class Score
  {
      public string Letter {get; set; }
      public int Value {get; set; }

      public Score(string letter, int value)
      {
        Letter = letter;
        Value = value;
      }
      public string getLetter()
      {
        return Letter;
      }

      public int GetValue()
      {
        return Value;
      }
    }
  }





// Make a console application that takes a word and returns the Scrabble score for that word. Make sure to start with your specs, and that you include a README for this project and create a Git repository for it. Here are the values of letters in Scrabble:

// A, E, I, O, U, L, N, R, S, T       1
// D, G                               2
// B, C, M, P                         3
// F, H, V, W, Y                      4
// K                                  5
// J, X                               8
// Q, Z                               10
