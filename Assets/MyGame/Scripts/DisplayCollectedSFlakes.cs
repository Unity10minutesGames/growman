using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCollectedSFlakes : MonoBehaviour {

    private TextMeshProUGUI collectedSnowflakeText;

    // Use this for initialization
    void Start () {
        collectedSnowflakeText = GetComponent<TextMeshProUGUI>();
        Debug.Log(collectedSnowflakeText == null);
        //collectedSnowflakeText.text = GameSessionSingleton.instance.collectedSnowflakes.ToString();
        collectedSnowflakeText.text = GameSessionSingleton.instance.CalcPercent().ToString() + "kg ";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
