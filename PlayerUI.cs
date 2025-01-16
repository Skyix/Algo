using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI health;
    public TextMeshProUGUI coins;
    public TextMeshProUGUI TimerSec;
    public TextMeshProUGUI TimerMin;
    public Timer timer;

    // Update is called once per frame
    void Update()
    {
        health.text = player.Health.ToString();
        coins.text = player.Coins.ToString();
        TimerMin.text = timer.minutes.ToString();
        TimerSec.text = ":" + timer.seconds.ToString();
    }
}
