using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager instance;

    private string currentLevelName;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to instantiate a second");
        }
    }

    //Methods to load and unload scenes

    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName,LoadSceneMode.Additive);

        if(ao == null)
        {
            Debug.LogError("[Gamemanager] Unable to load level " + levelName);
            return;
        }
        currentLevelName = levelName;
    }

    public void UnloadLevel(string levelName)
    {

    }

}
