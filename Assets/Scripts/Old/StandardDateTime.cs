using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class StandardDateTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DateTime dateTime = new DateTime(2025, 1, 23, 13, 24, 34);

        Debug.Log(dateTime.ToString("d", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), "한국 {0:D}", dateTime));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),$"한국 {dateTime:d}"));

        Debug.Log(dateTime.ToString("D", CultureInfo.CreateSpecificCulture("ja-JP")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),$"korea {dateTime:D}"));

        Debug.Log(dateTime.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),$"korea {dateTime:F}"));

        Debug.Log(dateTime.ToString("U", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),$"korea {dateTime:U}"));

        Debug.Log(string.Format("{0:yyyyMMdd_HHmmss}",dateTime));
        Debug.Log($"{dateTime:yyyyMMdd_HHmmss}");
        Debug.Log($"{dateTime:d}   {dateTime:ddd}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
