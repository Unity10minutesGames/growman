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
    
    public int collectedSnowflakes;
    public int missedSnowflakes;

    private int CalcSpawnedSnowflakes()
    {
        return collectedSnowflakes + missedSnowflakes;
    }

    public float CalcPercent()
    {
        int sumCollectableSnowflakes = collectedSnowflakes + missedSnowflakes;
        if (sumCollectableSnowflakes == 0)
        {
            return Mathf.Round(100 * collectedSnowflakes / 20);
        }

        return Mathf.Round(100 * collectedSnowflakes / sumCollectableSnowflakes);
    }


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
	}
	
	void Update () {

        if (sceneLoader.GetCurrenScene().name == SceneLoader.SCENEGROWMANMAIN)
        {
            StartCountdown();
            LoadGameOverScene();
        }

        else if (sceneLoader.GetCurrenScene().name == SceneLoader.SCENEWELCOME)
        {
            collectedSnowflakes = 0;
            missedSnowflakes = 0;
        }

        
	}

    private void LoadGameOverScene()
    {
        if (countdown.timeRemaining == 0)
        {
            isCountdownActivated = false;
            sceneLoader.LoadGameOver();
        }
    }

    private void StartCountdown()
    {
        if (!isCountdownActivated)
        {
            isCountdownActivated = true;
            countdown.StartCountDown();
        }
    }

    public void addMissedSnowflake()
    {
        missedSnowflakes++;
    }

    public void addCollectedSnowflake()
    {
        collectedSnowflakes++;
    }
}
