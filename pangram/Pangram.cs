using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        Console.WriteLine("-------------------");
        //first check if input is a blank string.
        if(input == "")
            return false;

        //create list of all characters of alphabet.
        var listOfLetters = new List<string>();
        for ( int i = 0; i < 26; i++ )
        {
            var letter = Convert.ToChar( i + 65 );
            listOfLetters.Add( Convert.ToString(letter).ToLower() );
        }

        var listOfInput = new List<string>();
        //convert "input" string to List 
        for(int i = 0; i < input.Length; i++){
            listOfInput.Add(Convert.ToString(input[i]).ToLower());
        }

        //check if input contains the letters of the alphabet, checking all letters.
        foreach(var letter in listOfLetters)
        {
            Console.WriteLine(letter);
            if(!listOfInput.Contains(letter))
            {
                return false;
            }
        }
        //if code reaches this point, return true.
        return true;

        throw new NotImplementedException();
    }
}
