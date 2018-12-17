using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    private const string SCENEWELCOME     = "Welcome";
    private const string SCENEGAMEOVER    = "GameOver";
    private const string SCENEGROWMANMAIN = "GrowmanMain";

    void LoadMainGame()
    {
        SceneManager.LoadScene(SCENEGROWMANMAIN);
    }

    void LoadWelcome()
    {
        SceneManager.LoadScene(SCENEWELCOME);
    }

    void LoadGameOver()
    {
        SceneManager.LoadScene(SCENEGAMEOVER);
    }
}
