using System;

public class Clock
{
    private int _currentHour;
    private int _currentMinutes;
    private int _theHours;
    private int _theMinutes;
    public Clock(int hours, int minutes)
    {
        this._theHours = hours;
        this._theMinutes = minutes;

        this.CalculateTime();
    }

    public Clock Add(int minutesToAdd)
    {
        this._theMinutes += minutesToAdd;
        return new Clock(this._theHours, this._theMinutes);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        this._theMinutes -= minutesToSubtract;
        this.CalculateTime();
        return new Clock(this._theHours, this._theMinutes);
    }

    // public override string ToString() => $"{hourInString:00}:{minutesInString:00}";

    public override string ToString()
    {
        var hourInString = this._currentHour.ToString();
        if(this._currentHour < 10) {
            hourInString = "0" + hourInString;
        }
        var minutesInString = this._currentMinutes.ToString();
        if(this._currentMinutes < 10) {
            minutesInString = "0" + minutesInString;
        }
        return hourInString + ":" + minutesInString;
    }

    public void CalculateTime()
    {
        this._currentHour = this._theHours;
        this._currentMinutes = this._theMinutes;

        var hours = this._theHours;
        var minutes = this._theMinutes;

        //combine everything into minutes
        var hoursInMinutes = (hours * 60); 
        var totalTimeInMinutes = hoursInMinutes + minutes;
        // System.Console.WriteLine(totalTimeInMinutes);

        var extraDaysTakenOff = totalTimeInMinutes % 1440;

        // System.Console.WriteLine(extraDaysTakenOff); //20

        float extraTimeConvertedToHours = ((float)extraDaysTakenOff / 60.0f);

        var stringVer = extraTimeConvertedToHours.ToString().Split('.');

        //hours:
        var remainderHours = int.Parse(stringVer[0]);
        // System.Console.WriteLine(remainderHours);
        //minutes: 
        var remainderMinutes = extraDaysTakenOff - int.Parse(stringVer[0])*60;
        // System.Console.WriteLine(remainderMinutes);

        if(remainderHours < 0) {
            this._currentHour = 24 + remainderHours;
        } else if (remainderHours > 0 ) {
            this._currentHour = remainderHours;
        } else if (remainderHours == 0 ) {
           this._currentHour = 24;
        }
        
        if(remainderMinutes < 0) {
            if(this._currentHour == 0 ) {
                this._currentHour = 24;
            } else {
                this._currentHour -= 1;
            }
            this._currentMinutes = 60 + remainderMinutes;
        } else if (remainderMinutes >= 0 && remainderMinutes < 60 ) {
            this._currentMinutes = remainderMinutes;
            if(this._currentHour == 24 ) {
                this._currentHour = 0;
            }
        }
    }

    public override bool Equals (object obj) {
        if(this.ToString() == obj.ToString()) {
            return true;
        } else {
            return false;
        }
    }
}



// using System;

// public struct Clock
// {
//     public Clock(int hours, int minutes)
//     {
//         const int minutesPerDay = 60 * 24;
//         minutes += hours * 60;
//         minutes %= minutesPerDay;
//         while (minutes < 0) minutes += minutesPerDay;
//         Hours = (minutes / 60) % 24;
//         Minutes = minutes % 60;
//     }

//     public int Hours { get; }

//     public int Minutes { get; }

//     public Clock Add(int minutesToAdd) => new Clock(Hours, Minutes + minutesToAdd);

//     public override string ToString() => $"{Hours:00}:{Minutes:00}";

//     // no need for an Equals() override, the default comparer does the right thing,
//     //  see https://msdn.microsoft.com/en-us/library/2dts52z7(v=vs.110).aspx
// }