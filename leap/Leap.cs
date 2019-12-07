using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool status;
        bool evenDiv4 = (year % 4 == 0);
        bool evenDiv100 = (year % 100 == 0);
        bool evenDiv400 = (year % 400 == 0);

        if( evenDiv4 && (!evenDiv100 || evenDiv400) )
            status = true;
        else
            status = false;

        return status;
    }
}
