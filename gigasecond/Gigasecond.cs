using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        var aGigasecond = 1000000000;
        return moment.AddSeconds(aGigasecond);
    }
}