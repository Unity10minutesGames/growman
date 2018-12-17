using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCollectedSFlakes : MonoBehaviour {

    private TextMeshProUGUI collectedSnowflakeText;

    // Use this for initialization
    void Start () {
        collectedSnowflakeText = GetComponent<TextMeshProUGUI>();
        collectedSnowflakeText.text = GameSessionSingleton.instance.CalcPercent().ToString() + "kg ";
    }
}
