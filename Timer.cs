using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;

    // Update is called once per frame
    void Update()
    {
        seconds--;

        if(seconds == 0)
        {
            if(minutes > 0)
            {
                minutes--;
                seconds += 59;
            }
            else
            {
                int SceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(SceneIndex);
            }
        }
    }
}
