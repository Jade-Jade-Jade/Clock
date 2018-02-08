using System;
using UnityEngine;

public class ClockAnimator : MonoBehaviour {

    public Transform hours, minutes, seconds;

    private const float
        HOURSTODEGREES = 360f / 12f,
        MINTUESTODEGREES = 360f / 60f,
        SECONDSTODEGREES = 360f / 60f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DateTime time = DateTime.Now;
        hours.localRotation =
            Quaternion.Euler(0f, 0f, time.Hour * -HOURSTODEGREES);
        minutes.localRotation =
            Quaternion.Euler(0f, 0f, time.Minute * -MINTUESTODEGREES);
        seconds.localRotation =
            Quaternion.Euler(0f, 0f, time.Second * -SECONDSTODEGREES);
    }
}
