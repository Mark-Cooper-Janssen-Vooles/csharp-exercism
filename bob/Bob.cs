using System;

public static class Bob
{

    public static string Response(string statement)
    {
        return Identifier(statement);
    }

    private static string Identifier(string statement) 
    {
        string response = "";
        if (isYelling(statement) && isQuestion(statement)) 
            response = "Calm down, I know what I'm doing!";
        else if(isYelling(statement)) 
            response = "Whoa, chill out!";
        else if (isQuestion(statement)) 
            response = "Sure.";
        else if (isSayingNothing(statement))
            response = "Fine. Be that way!";
        else 
            response = "Whatever.";
        
        return response;
    }

    private static bool isYelling(string statement)
    {
        var allCapitals = true;
        //check if there are any letters:
        var anyLetters = false;
        //check if string is all capitals:
        if (!String.IsNullOrWhiteSpace(statement)) 
        {
            for(var i = 0; i < statement.Length; i++ )
            {
                var currentCharacter = statement[i];
                var characterIsCapital = Char.IsUpper(currentCharacter);
                var characterIsLetter = Char.IsLetter(currentCharacter);
                if (characterIsLetter)
                    anyLetters = true;
                if (!characterIsCapital && characterIsLetter)
                    allCapitals = false; 
            }
        }

        if(anyLetters == false)
            allCapitals = false;

        return allCapitals;
    }

    private static bool isQuestion(string statement)
    {
        //check to see if last character is ?
        var question = false;
        if (!String.IsNullOrWhiteSpace(statement))
        {
            var betterStatement = statement.Trim();
            if(betterStatement[betterStatement.Length - 1] == '?')
                question = true;
        }
        return question;
    }

    private static bool isSayingNothing(string statement)
    {
        var sayingNothing = true;
        if (!String.IsNullOrWhiteSpace(statement))
            sayingNothing = false;
        
        return sayingNothing;
    }
}
