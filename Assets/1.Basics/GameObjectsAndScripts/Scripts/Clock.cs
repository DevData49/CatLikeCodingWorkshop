using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    const float hoursToDegrees = -30f, secondsToDegree = -6f, minutesTodegree = -6f;
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    
    private void Update()
    {
        
        var  time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesTodegree * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegree * (float)time.TotalSeconds);
    }
}
