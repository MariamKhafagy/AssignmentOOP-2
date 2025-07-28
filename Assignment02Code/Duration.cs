using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02Code
{
    #region Part 3
    //public class Duration
    //{
    //    public int Hours { get; set; }
    //    public int Minutes { get; set; }
    //    public int Seconds { get; set; }


    //public Duration(int hours, int minutes, int seconds)
    //{
    //    Hours = hours;
    //    Minutes = minutes;
    //    Seconds = seconds;

    //    Normalize();

    //}

    //public Duration(int totalSeconds)
    //{
    //    Hours = totalSeconds / 3600;
    //    totalSeconds %= 3600;
    //    Minutes = totalSeconds / 60;
    //    Seconds = totalSeconds % 60;

    //}

    //public Duration() : this(0, 0, 0)
    //{

    //}

    //private int ToTotalSeconds()
    //{
    //    return Hours * 3600 + Minutes * 60 + Seconds;
    //}

    //private void Normalize()
    //{
    //    int total = ToTotalSeconds();
    //    Hours = total / 3600;
    //    Minutes = (total % 3600) / 60;
    //    Seconds = total % 60;



    //}

    //public override string ToString()
    //{
    //    if (Hours > 0)
    //        return $"Hours : {Hours},Minutes : {Minutes}, Seconds : {Seconds}";
    //    else if (Minutes > 0)
    //    {
    //        return $"Minutes : {Minutes} , Seconds : {Seconds}";

    //    }
    //    else
    //        return $"Seconds : {Seconds}";
    //}

    //public override bool Equals(object? obj)
    //{
    //    if (obj is Duration other)
    //        return this.ToTotalSeconds() == other.ToTotalSeconds();
    //    return false;
    //}
    //public override int GetHashCode()
    //{
    //    return ToTotalSeconds().GetHashCode();
    //}


    //public static Duration operator +(Duration d1, Duration d2)
    //{
    //    return new Duration(d1.ToTotalSeconds() + d2.ToTotalSeconds());

    //}

    //public static Duration operator +(Duration d, int seconds)
    //{
    //    return new Duration(d.ToTotalSeconds() + seconds);

    //}
    //public static Duration operator +(int seconds, Duration d)
    //{
    //    return d +seconds;
    //}

    //public static  Duration operator ++(Duration d)
    //{
    //    return new Duration(d.ToTotalSeconds() + 60);

    //}
    //public static Duration operator --(Duration d)
    //{
    //    int newSeconds = d.ToTotalSeconds() - 60;
    //    return new Duration(Math.Max(0,newSeconds));


    //}

    //public static Duration operator -(Duration d1, Duration d2)
    //{
    //    return new Duration(d1.ToTotalSeconds() - d2.ToTotalSeconds());


    //}
    //public static  bool operator >(Duration d1, Duration d2)
    //{
    //    return d1.ToTotalSeconds() > d2.ToTotalSeconds();


    //}
    //public static bool operator <(Duration d1, Duration d2)
    //{ 
    //return d1.ToTotalSeconds() < d2.ToTotalSeconds();

    //}
    //public static bool operator >=(Duration d1, Duration d2)
    //{
    //    return d1.ToTotalSeconds() >= d2.ToTotalSeconds();


    //}
    //public static bool operator <=(Duration d1, Duration d2)
    //{ 
    // return d1.ToTotalSeconds() <= d2.ToTotalSeconds();

    //}

    //public static bool operator true(Duration d)
    //{ 
    //  return d.ToTotalSeconds() != 0;
    //}

    //public static bool operator false(Duration d)
    //{ 
    //  return d.ToTotalSeconds()==0;
    //}

    //public static explicit operator TimeSpan(Duration d)
    //{
    //    return new TimeSpan(d.Hours, d.Minutes, d.Seconds);
    //}

    #endregion 
}


