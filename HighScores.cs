using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> highScore = new List<int>();
    
    public HighScores(List<int> list)
    {
        highScore = list;
    }

    public List<int> Scores()
    {
        return highScore;
    }

    public int Latest()
    {
        return highScore.Last();
    }

    public int PersonalBest()
    {
        return highScore.Max();
    }

    public List<int> PersonalTopThree()
    {
        List<int> topThree = new List<int>();
        
        for(int i = 0; i < 3; i++)
        {
            topThree.Add(highScore.Max());
            highScore.Remove(topThree.Last<int>());
            
            if(highScore.Count == 0)
            {
                break;
            }
        }

        return topThree;
    }
}