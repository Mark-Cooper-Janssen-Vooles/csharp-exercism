using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        Console.WriteLine("\n ----------------------");
        //first check for empty entry.
        if(word == "")
        {
            return true;
        }

        Console.WriteLine("second area");

        var wordList = new List<string>();
        for(int i = 0; i < word.Length ; i++)
        {
            var letter = Convert.ToString(word[i]).ToLower();
            if (letter != " ")
                wordList.Add(letter);
        }
        //short hand to display each item in a list:
        // wordList.ForEach(Console.WriteLine);

        //create a new list, and push each letter from the old list. check to see if it contains it first, and if it does return false. 
        var listChecker = new List<string>();
        foreach(var letter in wordList)
        {
            if(!listChecker.Contains(letter) || letter == "-")
            {
                listChecker.Add(letter);
            } else //i.e. if letter is already contained in there
            {
                return false;
            }
        }

        //if it gets to this part, return true
        return true;

        throw new NotImplementedException("You need to implement this function.");
    }
}
