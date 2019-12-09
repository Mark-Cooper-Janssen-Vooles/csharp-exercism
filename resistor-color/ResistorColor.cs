using System;
using System.Collections.Generic;
public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int colorIndex = 0;
        var colours = Colors();
        for(var i = 0; i < colours.Length; i++)
        {
            if(colours[i] == color)
            {
                colorIndex = i;
            }
        }
        return colorIndex;
    }

    public static string[] Colors()
    {
        var colors = new String[10] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        return colors;
    }
}