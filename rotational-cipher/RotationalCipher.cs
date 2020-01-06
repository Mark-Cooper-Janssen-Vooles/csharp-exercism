using System;
using System.Collections.Generic;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        // text = text.ToLower();
        var returnList = new List<string>(); 
        System.Console.WriteLine(text);

        var alphabet = new List<char>() {
                'a', 'b', 'c', 'd', 'e', 
                'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm', 'n', 'o',
                'p', 'q', 'r', 's', 't',
                'u', 'v', 'w', 'x', 'y', 'z'};

        foreach (var character in text) {
            System.Console.WriteLine(character);
            if(character.ToString() == " ")
            {
                returnList.Add(" ");
            } else if (alphabet.FindIndex( x => x==Char.ToLower(character)) == -1) {    
                returnList.Add(character.ToString());
            } else {
                var upperCase = Char.IsUpper(character);

                var foundCharIndex = alphabet.FindIndex( x => x==Char.ToLower(character));
                System.Console.WriteLine(foundCharIndex);
                var CharShiftKey = shiftKey + foundCharIndex;

                if(CharShiftKey > 25) {
                    CharShiftKey = CharShiftKey - 26;
                }
                var returnValue = alphabet[CharShiftKey].ToString();

                if(upperCase)
                {
                    returnValue = returnValue.ToUpper();
                }

                returnList.Add(returnValue);
            }
        }

        System.Console.WriteLine("====================");
        Console.WriteLine(String.Join( "", returnList.ToArray() ));

        return String.Join( "", returnList.ToArray() );
    }
}