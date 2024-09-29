using UnityEngine;
using System;


public class Clock : MonoBehaviour {
	public Transform hoursTransform;
	public Transform minutesTransform;
	public Transform secondsTransform;

    // Add this variable to set the time zone offset
    public int timeZoneOffset = 0;

    const float degreesPerHour = -30f, degreesPerMinute = -6f, degreesPerSecond = -6f;


    void Update(){
        UpdateClock();
    }


    void UpdateClock() {
        // Get the current UTC time and apply the time zone offset
        DateTime time = DateTime.UtcNow.AddHours(timeZoneOffset);

        // Set the rotation of clock hands based on the adjusted time
        hoursTransform.localRotation = Quaternion.Euler(0f, 0f, time.Hour * degreesPerHour);
        minutesTransform.localRotation = Quaternion.Euler(0f, 0f, time.Minute * degreesPerMinute);
        secondsTransform.localRotation = Quaternion.Euler(0f, 0f, time.Second * degreesPerSecond);
    }
}
