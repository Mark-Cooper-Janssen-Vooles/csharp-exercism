using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> highScores; 
    public HighScores(List<int> list)
    {
        highScores = list;
    }

    public List<int> Scores()
    {
        return highScores;
    }

    public int Latest()
    {
        throw new NotImplementedException();
    }

    public int PersonalBest()
    {
        throw new NotImplementedException();
    }

    public List<int> PersonalTopThree()
    {
        throw new NotImplementedException();
    }
}