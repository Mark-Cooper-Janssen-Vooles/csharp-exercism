using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int colorIndex;
        switch(color)
        {
            case "black":
                colorIndex = 0;
                break;
            case "brown":
                colorIndex = 1;
                break;
            case "red":
                colorIndex = 2;
                break;
            case "orange":
                colorIndex = 3;
                break;
            case "yellow":
                colorIndex = 4;
                break;
            case "green":
                colorIndex = 5;
                break;
            case "blue":
                colorIndex = 6;
                break;
            case "violet":
                colorIndex = 7;
                break;
            case "grey":
                colorIndex = 8;
                break;
            case "white":
                colorIndex = 9;
                break;
            default: 
                colorIndex = -1;
                break;
        }

        return colorIndex;
    }

    public static string[] Colors()
    {
        var colors = new String[10] {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};

        return colors;
    }
}