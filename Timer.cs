using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;

    // Update is called once per frame
    void Update()
    {
        seconds++;

        if(seconds >= 60)
        {
            seconds = 0;
            minutes++;
        }
    }
}
