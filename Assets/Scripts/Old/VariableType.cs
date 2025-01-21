using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;
using Debug = UnityEngine.Debug;

public class VariableType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //float npi = pi + 10;

        string s = null;
        int? ii = null;

        TimeSpanExample();
        
        DateTime dt = new DateTime(2019, 1, 17, 14, 23, 45);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TimeSpanExample()
    {
        DateTime dt1 = new DateTime(2018, 8, 1, 2, 3, 4);
        DateTime dt2 = new DateTime(2019, 10, 20, 12, 0, 5);

        TimeSpan ts = dt2 - dt1;

        Debug.Log(ts.Days.ToString());
        Debug.Log(ts.Hours.ToString());
        Debug.Log(ts.Minutes.ToString());
        Debug.Log(ts.Seconds.ToString());

        Debug.Log(ts.TotalHours.ToString());
        Debug.Log(ts.TotalMinutes.ToString());

        Stopwatch sw = new Stopwatch();
    }
}
