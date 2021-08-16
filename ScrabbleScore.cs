using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int score = 0;
        string wordToScore = input.ToUpper();

        char[] scoreOf1 = new char[] { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };
        char[] scoreOf2 = new char[] { 'D', 'G' };
        char[] scoreOf3 = new char[] { 'B', 'C', 'M', 'P' };
        char[] scoreOf4 = new char[] { 'F', 'H', 'V', 'W', 'Y' };
        char[] scoreOf5 = new char[] { 'K' };
        char[] scoreOf8 = new char[] { 'J', 'X' };
        char[] scoreOf10 = new char[] { 'Q', 'Z' };

        foreach (char item in wordToScore)
        {
            LoopThroughScoreArrays(item, scoreOf1, ref score, 1);
            LoopThroughScoreArrays(item, scoreOf2, ref score, 2);
            LoopThroughScoreArrays(item, scoreOf3, ref score, 3);
            LoopThroughScoreArrays(item, scoreOf4, ref score, 4);
            LoopThroughScoreArrays(item, scoreOf5, ref score, 5);
            LoopThroughScoreArrays(item, scoreOf8, ref score, 8);
            LoopThroughScoreArrays(item, scoreOf10, ref score, 10);
        }

        return score;
    }

    public static void LoopThroughScoreArrays(char c, char[] scoreArray, ref int score, int scoreToAdd)
    {
        foreach (char item in scoreArray)
        {
            if (c == item)
                score += scoreToAdd;
        }
    }
}