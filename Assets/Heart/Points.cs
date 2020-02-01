using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static  class Points
{
    static int points = 0;
    public static IntTracker tracker;
    public static void IncreasePoints()
    {
        points++;
        tracker.SetValue(points);
    }

    public static void Reset()
    {
        points = 0;
        tracker.SetValue(0);
    }
}
