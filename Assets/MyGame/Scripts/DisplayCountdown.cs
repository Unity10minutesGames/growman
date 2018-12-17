using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCountdown : MonoBehaviour {

    public GameSessionSingleton gsession;

    private Text countdownText;

    private void Start()
    {
        countdownText = GetComponent<Text>();
    }

    private void Update()
    {
        if (gsession != null)
        {
            countdownText.text = gsession.countdown.timeRemaining.ToString();
        }
        else
        {
            gsession = FindObjectOfType<GameSessionSingleton>();
        }
       
    }
}
