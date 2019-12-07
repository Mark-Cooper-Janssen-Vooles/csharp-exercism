using System;

public class SpaceAge
{
    public int Seconds;

    public SpaceAge(int seconds)
    {
        Seconds = seconds;
    }

    public double OnEarth()
    {
        float theAge; 
        theAge = 1;

        System.Console.WriteLine("==========");
        System.Console.WriteLine(Seconds);

        var convertMinutes = (Seconds / 60f);
        var convertHours = convertMinutes / 60f;
        var convertDays = convertHours / 24f;
        var convertYears = convertDays / 365.25f;

        theAge = (float)Math.Round(convertYears, 2);

        System.Console.WriteLine(theAge);
        return theAge;
    }

    public double OnMercury()
    {
        double theAge = OnEarth() / 0.2408467;
        return theAge;
    }

    public double OnVenus()
    {
        double theAge = OnEarth() / 0.61519726;
        return theAge;
    }

    public double OnMars()
    {
        double theAge = OnEarth() / 1.8808158;
        return theAge;
    }

    public double OnJupiter()
    {
        double theAge = OnEarth() / 11.862615;
        return theAge;
    }

    public double OnSaturn()
    {
        double theAge = OnEarth() / 29.447498;
        return theAge;
    }

    public double OnUranus()
    {
        double theAge = OnEarth() / 84.016846;
        return theAge;
    }

    public double OnNeptune()
    {
        double theAge = OnEarth() / 164.79132;
        return theAge;
    }
}