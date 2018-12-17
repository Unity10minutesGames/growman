using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    private const string SCENEWELCOME     = "Welcome";
    private const string SCENEGAMEOVER    = "GameOver";
    private const string SCENEGROWMANMAIN = "GrowmanMain";

    public void LoadMainGame()
    {
        Debug.Log("in onclick main");
        SceneManager.LoadScene(SCENEGROWMANMAIN);
    }

    public void LoadWelcome()
    {
        Debug.Log("in onclick welcome");
        SceneManager.LoadScene(SCENEWELCOME);
    }

    public void LoadGameOver()
    {
        Debug.Log("in onclick gameover");
        SceneManager.LoadScene(SCENEGAMEOVER);
    }
}
