using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSessionSingleton : MonoBehaviour {

    public static GameSessionSingleton instance = null;

    public Countdown countdown;
    public SceneLoader sceneLoader;
    public bool isCountdownActivated;


    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    void Start () {
        sceneLoader = GetComponent<SceneLoader>();
        countdown = GetComponent<Countdown>();
        isCountdownActivated = false;

       Debug.Log("init sigelton");
	}
	
	void Update () {

        if (sceneLoader.GetCurrenScene().name == SceneLoader.SCENEGROWMANMAIN)
        {
            if (!isCountdownActivated)
            {
                isCountdownActivated = true;
                countdown.StartCountDown();
            }

            if (countdown.timeRemaining == 0)
            {
                isCountdownActivated = false;
                sceneLoader.LoadGameOver();
            }

            if (isCountdownActivated)
            {
                Debug.Log(countdown.timeRemaining);
            }
            
        }
	}
}
