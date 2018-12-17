using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public const string SCENEWELCOME     = "Welcome";
    public const string SCENEGAMEOVER    = "GameOver";
    public const string SCENEGROWMANMAIN = "GrowmanMain";

    private void OnEnable()
    {
        //Debug.Log("enable sceneloader");
    }

    public void LoadMainGame()
    {
        //Debug.Log("Load main");
        SceneManager.LoadScene(SCENEGROWMANMAIN);
    }

    public void LoadWelcome()
    {
        //Debug.Log("Load welcome");
        SceneManager.LoadScene(SCENEWELCOME);
    }

    public void LoadGameOver()
    {
        //Debug.Log("load gameover");
        SceneManager.LoadScene(SCENEGAMEOVER);
    }

    public Scene GetCurrenScene()
    {
        return SceneManager.GetActiveScene();
    }

    
}
