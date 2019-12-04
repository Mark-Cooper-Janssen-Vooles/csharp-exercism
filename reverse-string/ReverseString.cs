using System;
using System.Collections.Generic;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if(input == ""){
            return "";
        }

        var newList = new List<string>();
        for(var i = input.Length - 1; i >= 0; i--)
        {
            // Console.WriteLine(input[i]);
            newList.Add(input[i].ToString());
        }

        var returnThis = String.Join("", newList);
        return returnThis;
    }
}
